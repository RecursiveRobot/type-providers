#r @".\packages\FSharp.Data\lib\net45\FSharp.Data.dll"
#r @".\packages\FSharp.Data.SqlClient\lib\net40\FSharp.Data.SqlClient.dll"

open FSharp.Data

[<Literal>]
let ConnectionString = @"Data Source=.;Initial Catalog=AdventureWorks2017;Integrated Security=True"

// let salesQuery = new SqlCommandProvider<"
//             SELECT TOP(@Count)
//                 BusinessEntityId,
//                 FirstName, 
//                 LastName, 
//                 SalesYTD 
//             FROM 
//                 Sales.vSalesPerson
//             WHERE 
//                 CountryRegionName = @RegionName AND 
//                 SalesYTD > @SalesMoreThan 
//             ORDER BY 
//                 SalesYTD DESC
//             " , ConnectionString>(ConnectionString)

// salesQuery.Execute(Count = 3L, RegionName = "United States", SalesMoreThan = 1_000_000M) |> printfn "%A"

// let renumerationQuery = new SqlCommandProvider<"
//             SELECT 
//                Bonus,
//                CommissionPct
//             FROM 
//                 Sales.SalesPerson
//             WHERE 
//                 BusinessEntityId = @BusinessEntityId
//             ", ConnectionString>(ConnectionString)

// renumerationQuery.Execute(275) |> Seq.toArray

// async {
//     let! topSalesPeople = salesQuery.AsyncExecute(1L, "United States", 1_000_000M)
//     let topSalesPerson = topSalesPeople |> Seq.head
//     let! renumerationInfo = renumerationQuery.AsyncExecute(topSalesPerson.BusinessEntityId)
//     return (topSalesPerson, renumerationInfo |> Seq.head)
// }
// |> Async.RunSynchronously