module Task14

open FSharp.Charting
open System.Drawing
open System.Windows.Forms

let time f =
    let start = System.DateTime.Now
    for i = 1 to 20 do f()
    (System.DateTime.Now - start).TotalMilliseconds / 20.00

let main =
    Chart.Combine
        [
             Chart.Line( [ for i in 10..2..30 -> (i, time(fun () -> Task8.main i |> ignore) ) ], "Rec. method", Color = System.Drawing.Color.Black)
             Chart.Line( [ for i in 1..1000..100000 -> (i, time(fun () -> Task9.main i |> ignore) ) ], "Iter. method", Color = System.Drawing.Color.Gold)
             Chart.Line( [ for i in 1..1000..70000 -> (i, time(fun () -> Task10.main i |> ignore) ) ], "Iter. method without mutable", Color = System.Drawing.Color.Gray)
             Chart.Line( [ for i in 1..1000..20000 -> (i, time(fun () -> Task11.main i |> ignore) ) ], "Matrix, easy method", Color = System.Drawing.Color.Blue)
             Chart.Line( [ for i in 1..1000..30000 -> (i, time(fun () -> Task12.main i |> ignore) ) ], "Matrix, log", Color = System.Drawing.Color.Green)
             Chart.Line( [ for i in 1..1000..100000 -> (i, time(fun () -> Task13.main i |> ignore) ) ], "Array", Color = System.Drawing.Color.Red)
        ]
do System.Windows.Forms.Application.Run(main.ShowChart())