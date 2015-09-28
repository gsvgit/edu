//module Task14
//
//open FSharp.Charting
//open Task8
//open Task9
//open Task10
//open Task11
//open Task12
//open Task13
//
//let time f =
//    let start = System.DateTime.Now
//    for i in 0..9 do f ()
//    (System.DateTime.Now - start).TotalMilliseconds / 10.0
//
//let gch = 
//    Chart.Combine
//     [Chart.Line( [ for i in 10..5..35 -> (i,time (fun () -> Task8.main i |> ignore) ) ], Color = System.Drawing.Color.Red)
//      Chart.Line( [ for i in 1000..100..100000 -> (i,time (fun () -> Task9.main i |> ignore) ) ], Color = System.Drawing.Color.Green)
//      Chart.Line( [ for i in 1000..100..100000 -> (i,time (fun () -> Task10.main i |> ignore) ) ], Color = System.Drawing.Color.Blue)
//      Chart.Line( [ for i in 1000..100..16000 -> (i,time (fun () -> Task11.main i |> ignore) ) ], Color = System.Drawing.Color.Black)
//      Chart.Line( [ for i in 1000..100..30000 -> (i,time (fun () -> Task12.main i |> ignore) ) ], Color = System.Drawing.Color.Gray)
//      Chart.Line( [ for i in 1000..100..100000 -> (i,time (fun () -> Task13.main i |> ignore) ) ], Color = System.Drawing.Color.Yellow)
//        ]
//
//
//do System.Windows.Forms.Application.Run(gch.ShowChart())
