module Task14

open FSharp.Charting
open System.Drawing
open System.Windows.Forms

let time f =
    let start = System.DateTime.Now
    for i = 1 to 300 do f()
    (System.DateTime.Now - start).TotalMilliseconds / 300.00

let charting =
    Chart.Combine
        [
             Chart.Line( [ for i in 10..2..30 -> (i, time(fun () -> Task8.main i |> ignore) ) ], "Recursion", Color = System.Drawing.Color.Green)
             Chart.Line( [ for i in 1..1000..100000 -> (i, time(fun () -> Task9.main i |> ignore) ) ], "Iteration", Color = System.Drawing.Color.Crimson)
             Chart.Line( [ for i in 1..1000..90000 -> (i, time(fun () -> Task10.main i |> ignore) ) ], "Iteration without mutable", Color = System.Drawing.Color.DarkGoldenrod)
             Chart.Line( [ for i in 1..1000..50000 -> (i, time(fun () -> Task11.main i |> ignore) ) ], "Matrix", Color = System.Drawing.Color.HotPink)
             Chart.Line( [ for i in 1..1000..100000 -> (i, time(fun () -> Task12.main i |> ignore) ) ], "Matrix : log", Color = System.Drawing.Color.Maroon)
             Chart.Line( [ for i in 1..1000..100000 -> (i, time(fun () -> Task13.main i |> ignore) ) ], "Fib in array", Color = System.Drawing.Color.MediumTurquoise)
        ]
do System.Windows.Forms.Application.Run(charting.ShowChart())