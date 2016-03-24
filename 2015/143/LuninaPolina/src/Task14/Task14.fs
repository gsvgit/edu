module Task14
open FSharp.Charting
open Task8
open Task9
open Task10
open Task11
open Task12
open Task13

let time f =
    let beg = System.DateTime.Now
    for i in 0..10 do f() |> ignore 
    (System.DateTime.Now - beg).TotalMilliseconds 

let main = 
    Chart.Combine (
        [Chart.Line ([for i in 0..30 -> (i, time(fun() -> Task8.main i))], Name = "rec", Color = System.Drawing.Color.Red)
         Chart.Line ([for i in 0..500..30000 -> (i, time(fun() -> Task9.main i))], Name = "iter", Color = System.Drawing.Color.Orange)
         Chart.Line ([for i in 0..500..30000 -> (i, time(fun() -> Task10.main i))], Name = "advanced iter", Color = System.Drawing.Color.Yellow)
         Chart.Line ([for i in 0..500..30000 -> (i, time(fun() -> Task11.main i))], Name = "mlt matrix", Color = System.Drawing.Color.Green)
         Chart.Line ([for i in 0..500..30000 -> (i, time(fun() -> Task12.main i))], Name = "mlt matrix: log", Color = System.Drawing.Color.Blue)
         Chart.Line ([for i in 0..500..30000 -> (i, time(fun() -> Task13.main i))], Name = "array", Color = System.Drawing.Color.Violet) ])

do System.Windows.Forms.Application.Run (main.ShowChart())

