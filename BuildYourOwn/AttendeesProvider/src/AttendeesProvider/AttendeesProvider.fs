module AttendeesProviderImplementation

open System.Reflection
open FSharp.Core.CompilerServices
open ProviderImplementation.ProvidedTypes

type Attendee =
    {   
        FirstName: string
        LastName: string 
    }

let parseName (fullName: string) =
    fullName.Split(' ')
    |> fun parts -> {
        FirstName = parts.[0]
        LastName = parts.[1]
    }

[<TypeProvider>]
type Provider (config: TypeProviderConfig) as this =
    inherit TypeProviderForNamespaces (config, addDefaultProbingLocation=true)

    let ns = "LambdaLuminaries"
    let asm = Assembly.GetExecutingAssembly()

    let createType typeName (attendees : string) =
        let asm = ProvidedAssembly()
        let myType = ProvidedTypeDefinition(asm, ns, typeName, Some typeof<obj>, isErased=false)

        let ctor = ProvidedConstructor([], invokeCode = fun _ -> <@@ "" :> obj @@>)
        myType.AddMember(ctor)

        attendees.Split(',')
        |> Seq.map (fun attendee -> ProvidedProperty(attendee, typeof<Attendee>, getterCode = fun _ -> <@@ parseName(attendee) @@>))
        |> Seq.iter(fun property -> myType.AddMember(property))

        asm.AddTypes [ myType ]
        myType

    let myParamType = 
        let t = ProvidedTypeDefinition(asm, ns, "AttendeeProvider", Some typeof<obj>, isErased=false)
        t.DefineStaticParameters( [ProvidedStaticParameter("Attendees", typeof<string>)], fun typeName args -> createType typeName (unbox<string> args.[0]))
        t
    do
        this.AddNamespace(ns, [myParamType])

[<TypeProviderAssembly>]
do ()
