#r @"AttendeesProvider\src\AttendeesProvider\bin\Debug\net45\AttendeesProvider.dll"

open LambdaLuminaries

[<Literal>]
let Attendees = "Attendee One,Attendee Two"

type AttendeesType = AttendeeProvider<Attendees>
let instance = AttendeesType()

instance.``Attendee One``.FirstName