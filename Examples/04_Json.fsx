#r @".\packages\FSharp.Data\lib\net45\FSharp.Data.dll"

open FSharp.Data

[<Literal>]
let Url = "http://api.meetup.com/lambda-luminaries/events?status=past,upcoming"

type MeetupProvider = JsonProvider<Url>

let meetups = MeetupProvider.Load(Url)

meetups
|> Seq.filter (fun a -> a.Name.Contains("F#"))
|> Seq.map (fun a -> (a.Name, a.LocalDate.ToShortDateString()))

[<Literal>]
let EventUrl = "http://api.meetup.com/lambda-luminaries/events/bgngtqyzjbnb/attendance"

type EventProvider = JsonProvider<EventUrl>

let attendance = EventProvider.Load(EventUrl)