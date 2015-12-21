module Task14

open FSharp.Charting
open Task8
open Task9
open Task10
open Task11
open Task12
open Task13

let time f =
    let start = System.DateTime.Now
    for i in 0..9 do f ()
    (System.DateTime.Now - start).TotalMilliseconds / 10.0

let gch = 
    Chart.Combine
        [
             Chart.Line( [ for i in 10..2..30 -> (i, time(fun () -> Task8.main i |> ignore) ) ], "Rec. method", Color = System.Drawing.Color.Yellow)
             Chart.Line( [ for i in 1..1000..100000 -> (i, time(fun () -> Task9.main i |> ignore) ) ], "Iter. method", Color = System.Drawing.Color.Green)
             Chart.Line( [ for i in 1..1000..90000 -> (i, time(fun () -> Task10.main i |> ignore) ) ], "Iter. method without mutable", Color = System.Drawing.Color.Gray)
             Chart.Line( [ for i in 1..1000..10000 -> (i, time(fun () -> Task11.main i |> ignore) ) ], "Matrix, easy method", Color = System.Drawing.Color.Blue)
             Chart.Line( [ for i in 1..1000..100000 -> (i, time(fun () -> Task12.main i |> ignore) ) ], "Matrix, log", Color = System.Drawing.Color.Black)
             Chart.Line( [ for i in 1..1000..100000 -> (i, time(fun () -> Task13.main i |> ignore) ) ], "Array", Color = System.Drawing.Color.Red)
        ]


do System.Windows.Forms.Application.Run(gch.ShowChart())