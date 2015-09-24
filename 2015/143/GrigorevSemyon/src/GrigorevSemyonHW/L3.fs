// add references to System.Drawing,
// System.Windows.Forms,
// System.Windows.Forms.DataVisualization
// https://msdn.microsoft.com/en-us/library/vstudio/hh297101(v=vs.100).aspx
// http://fslab.org/FSharp.Charting/PointAndLineCharts.html
module L3

open FSharp.Charting

let rand = new System.Random()

let getArr n = [|for i in 0..n -> float <| rand.Next()|]
let getLst n = [for i in 0..n -> float <| rand.Next()]

let time f =
    let start = System.DateTime.Now
    for i in 0..9 do f ()
    (System.DateTime.Now - start).TotalMilliseconds / 10.0

//List.sort
//Array.sort
let gch = 
    Chart.Combine
     [Chart.Line( 
        [ for i in 10000..500..100000 -> 
            let arr = getArr i
            (i,time (fun () -> Array.sort arr |> ignore)) ]
        ,Title = "arr")
      Chart.Line( 
        [ for i in 10000..500..100000 -> 
            let lst = getLst i
            (i,time (fun () -> List.sort lst |> ignore)) ]            
        ,Title = "Lst")
        ]


do System.Windows.Forms.Application.Run(gch.ShowChart())

