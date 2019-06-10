#r @"..\..\..\..\Examples\packages\FSharp.Quotations.Evaluator\lib\net45\FSharp.Quotations.Evaluator.dll"
open FSharp.Quotations.Evaluator
open Microsoft.FSharp.Quotations

let one = <@ 1 @>
let two = <@ 2 @>
let three = <@ 1 + 2 @>
let three' = <@ %one + %two @>

let add = <@ fun a b -> a + b @>
let addPlusOne = <@ fun a b -> (%add) a b + 1 @>