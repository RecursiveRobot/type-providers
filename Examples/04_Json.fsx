#r @".\packages\FSharp.Data\lib\net45\FSharp.Data.dll"

open FSharp.Data

[<Literal>]
let Url = "https://rickandmortyapi.com/api/character/"

type CharacterProvider = JsonProvider<Url>

let characters = CharacterProvider.Load(Url)

// characters.Results.[0].Name