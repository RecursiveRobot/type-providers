#r @".\packages\Google.DataTable.Net.Wrapper\lib\net45\Google.DataTable.Net.Wrapper.dll"
#r @".\packages\XPlot.GoogleCharts\lib\net472\XPlot.GoogleCharts.dll"
#r @".\packages\FSharp.Data\lib\net45\FSharp.Data.dll"

open FSharp.Data
open XPlot.GoogleCharts

type StockProvider = CsvProvider<"./data/StockPrices.csv">

let prices = StockProvider.Load("./data/StockPrices.csv")

// let firstRow = prices.Rows |> Seq.head

// prices.Rows
// |> Seq.map (fun row -> (row.Date, row.Open, row.Close, row.High, row.Low))
// |> Chart.Candlestick
// |> Chart.Show