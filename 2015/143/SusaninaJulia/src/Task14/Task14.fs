(*
module Task14

open FSharp.Charting
open System.Drawing
open System.Windows.Forms

let time f =
    let start = System.DateTime.Now
    for i = 1 to 100 do f()
    (System.DateTime.Now - start).TotalMilliseconds / 100.00

let charting =
    Chart.Combine
        [
             Chart.Line( [ for i in 10..2..30 -> (i, time(fun () -> Task8.main i |> ignore) ) ], "Task8", Color = System.Drawing.Color.Green)
             Chart.Line( [ for i in 1..1000..100000 -> (i, time(fun () -> Task9.main i |> ignore) ) ], "Task9", Color = System.Drawing.Color.Crimson)
             Chart.Line( [ for i in 1..1000..90000 -> (i, time(fun () -> Task10.main i |> ignore) ) ], "Task10", Color = System.Drawing.Color.DarkGoldenrod)
             Chart.Line( [ for i in 1..1000..10000 -> (i, time(fun () -> Task11.main i |> ignore) ) ], "Task11", Color = System.Drawing.Color.HotPink)
             Chart.Line( [ for i in 1..1000..100000 -> (i, time(fun () -> Task12.main i |> ignore) ) ], "Task12", Color = System.Drawing.Color.Maroon)
             Chart.Line( [ for i in 1..1000..100000 -> (i, time(fun () -> Task13.main i |> ignore) ) ], "Task13", Color = System.Drawing.Color.MediumTurquoise)
        ]
do System.Windows.Forms.Application.Run(charting.ShowChart())
*)