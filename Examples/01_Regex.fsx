#r @"packages\FSharp.Text.RegexProvider\lib\net40\FSharp.Text.RegexProvider.dll"

open FSharp.Text.RegexProvider

type RgbRegex = Regex< @"rgba\((?<Red>[012]\d\d|\d\d{0,1})\s*,\s*(?<Green>[012]\d\d|\d\d{0,1})\s*,\s*(?<Blue>[012]\d\d|\d\d{0,1})\)" >

// RgbRegex().TypedMatch("rgba(120, 255, 200)").Red.Value