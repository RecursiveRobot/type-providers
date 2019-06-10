#r @".\packages\FSharp.Data\lib\net45\FSharp.Data.dll"
#load @".\packages\FSharp.Charting\FSharp.Charting.fsx"

open FSharp.Data
open FSharp.Charting

let worldBank = WorldBankData.GetDataContext()

worldBank.Countries.``South Africa``.Indicators.``Incidence of malaria (per 1,000 population at risk)``
|> Seq.toList
|> Chart.Line

let countries = [
    worldBank.Countries.``South Africa``;
    worldBank.Countries.China;
    worldBank.Countries.``United States``
]

let plotCountry (country : WorldBankData.ServiceTypes.Country) =
    Chart.Line (country.Indicators.``CO2 emissions (kt)`` , Name = country.Name) 
    |> Chart.WithLegend (true)

countries
|> List.map plotCountry
|> Chart.Combine
