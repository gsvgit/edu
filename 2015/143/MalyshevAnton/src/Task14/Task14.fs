module Task14

open FSharp.Charting
let time f =
    let start = System.DateTime.UtcNow
    for i in 0..1000 do f ()
    (System.DateTime.UtcNow - start).TotalMilliseconds 

let a = Task12.main 7L
let gch = 
    Chart.Combine
     [//Chart.Line( [ for i in 10..5..35 -> (i,time (fun () -> Task8.main i |> ignore) ) ], Color = System.Drawing.Color.Red)
      Chart.Line( [ for i in 0..50..10000 -> (i,time (fun () -> Task9.main i |> ignore) ) ], Color = System.Drawing.Color.Green)
      Chart.Line( [ for i in 0..50..10000 -> (i,time (fun () -> Task10.main i |> ignore) ) ], Color = System.Drawing.Color.Blue)
      //Chart.Line( [ for i in 0..2..1000 -> (i,time (fun () -> Task11.main i |> ignore) ) ], Color = System.Drawing.Color.Black)
      Chart.Line( [ for i in 0L..50L..10000L -> (i,time (fun () -> Task12.main i |> ignore) ) ], Color = System.Drawing.Color.Gray)
      //Chart.Line( [ for i in 1000..100..100000 -> (i,time (fun () -> Task13.main i |> ignore) ) ], Color = System.Drawing.Color.Yellow)
        ]


do System.Windows.Forms.Application.Run(gch.ShowChart())