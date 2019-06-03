#r @".\packages\FSharp.Data\lib\net45\FSharp.Data.dll"

open FSharp.Data

[<Literal>]
let Url = "https://en.wikipedia.org/wiki/List_of_Rick_and_Morty_episodes"

type EpisodeProvider = HtmlProvider<Url>

let episodes = EpisodeProvider.Load(Url)

// episodes.Tables.``Season 1 (2013-14)``.Rows
// |> Seq.maxBy (fun row -> row.``U.S. viewers (millions)``)
