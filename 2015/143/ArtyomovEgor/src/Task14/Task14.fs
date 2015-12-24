﻿module Task14

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
    (Chart.Combine
        [
             Chart.Line( [ for i in 1..2..30 -> (i, time(fun () -> Task8.main i |> ignore) ) ], "рекурсия", Color = System.Drawing.Color.Yellow)
             Chart.Line( [ for i in 1..1000..100000 -> (i, time(fun () -> Task9.main i |> ignore) ) ], "итеративно", Color = System.Drawing.Color.Green)
             Chart.Line( [ for i in 1..100..300 -> (i, time(fun () -> Task10.main i |> ignore) ) ], "итеративно, функционально, волшебно", Color = System.Drawing.Color.Gray)
             Chart.Line( [ for i in 1..1000..5000 -> (i, time(fun () -> Task11.main i |> ignore) ) ], "матрицы", Color = System.Drawing.Color.Blue)
             Chart.Line( [ for i in 1..1000..50000 -> (i, time(fun () -> Task12.main i |> ignore) ) ], "матрицы за логарифм", Color = System.Drawing.Color.Black)
             Chart.Line( [ for i in 1..1000..50000 -> (i, time(fun () -> Task13.main i |> ignore) ) ], "через массив", Color = System.Drawing.Color.Red)
        ])

do System.Windows.Forms.Application.Run(gch.ShowChart())