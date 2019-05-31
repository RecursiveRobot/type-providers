#r @".\packages\FSharp.Data\lib\net45\FSharp.Data.dll"

open FSharp.Data

[<Literal>]
let Url = "https://en.wikipedia.org/wiki/List_of_Game_of_Thrones_episodes"

type EpisodeProvider = HtmlProvider<Url>

let episodes = EpisodeProvider.Load(Url)

// episodes.Tables.``Series overview``.Rows
// |> Seq.maxBy (fun row -> row.``Avg. U.S. viewers (millions)``.Split('[').[0] |> decimal)
