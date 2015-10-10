module Task14

open FSharp.Charting
let time f =
    let start = System.DateTime.UtcNow
    for i in 0..500 do f ()
    (System.DateTime.UtcNow - start).TotalMilliseconds
let T8 = Task8.main 5
let T9 = Task9.main 5
let T10 = Task10.main 5
let T11 = Task11.main 5
let T12 = Task12.main 5
let T13 = Task13.main 5
let gch = 
    Chart.Combine
        [Chart.Line( [ for i in 10..2..26 -> (i,time (fun () -> Task8.main i |> ignore) ) ], Color = System.Drawing.Color.Red)
         Chart.Line( [ for i in 0..1000..100000-> (i,time (fun () -> Task9.main i |> ignore) ) ], Color = System.Drawing.Color.Lime)
         Chart.Line( [ for i in 0..1000..100000 -> (i,time (fun () -> Task10.main i |> ignore) ) ], Color = System.Drawing.Color.Blue)
         Chart.Line( [ for i in 0..1000..10000 -> (i,time (fun () -> Task11.main i |> ignore) ) ], Color = System.Drawing.Color.Orange)
         Chart.Line( [ for i in 0..1000..100000 -> (i,time (fun () -> Task12.main i |> ignore) ) ], Color = System.Drawing.Color.Gold)
         Chart.Line( [ for i in 0..1000..10000 -> (i,time (fun () -> Task13.main i |> ignore) ) ], Color = System.Drawing.Color.Black)
         ]

do System.Windows.Forms.Application.Run(gch.ShowChart())