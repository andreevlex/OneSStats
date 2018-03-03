open System
open FSharp.Data

type NugetStats = HtmlProvider<"https://www.nuget.org/packages/OneScript">
let rawStats = NugetStats().Tables.``Version History``

[<EntryPoint>]
let main argv =
    rawStats.Rows |> Seq.iter (printfn "row = %A")

    0 // return an integer exit code
