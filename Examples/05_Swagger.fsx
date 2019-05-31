#r @".\packages\SwaggerProvider\lib\net45\SwaggerProvider.dll"
#r @".\packages\SwaggerProvider\lib\net45\SwaggerProvider.Runtime.dll"

open System
open SwaggerProvider

[<Literal>]
let Url = "https://petstore.swagger.io/v2/swagger.json"

type PetStore = SwaggerProvider<Url>

let store = PetStore()

// let id = 123L

// let rufus = PetStore.Pet(Name = "Rufus", Id = Some(id))

// store.AddPet(rufus)

// let retrievedPet = store.GetPetById(id)

// store.UpdatePet(PetStore.Pet(Id = Some(id), PhotoUrls = [|"https://www.photo.com"|]))

// let updatedPet = store.GetPetById(id)