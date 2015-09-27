module Task14

open FSharp.Charting


let fibN1 n = [|for i in 1..n -> float <| Task8.main i|]
let fibN2 n = [|for i in 1..n -> float <| Task9.main i|]
let fibN3 n = [|for i in 1..n -> float <| Task10.main i|]
let fibN4 n = [|for i in 1..n -> float <| Task11.main i|]
let fibN5 n = [|for i in 1..n -> float <| Task12.main i|]

let time f =
    let start = System.DateTime.Now
    for i in 0..9 do f ()
    (System.DateTime.Now - start).TotalMilliseconds / 10.0 / 1000.0

let gch = 
    Chart.Combine
     [Chart.Line( 
        [ for i in 1..40 -> 
            (i,time (fun () -> fibN1 i |> ignore)) 
        ], Title = "Task8", Color = System.Drawing.Color.Black);
      Chart.Line( 
        [ for i in 1..100..2000 -> 
            (i,time (fun () -> fibN2 i |> ignore)) 
        ], Title = "Task9", Color = System.Drawing.Color.Violet);
      Chart.Line( 
        [ for i in 1..100..2000 -> 
            (i,time (fun () -> fibN3 i |> ignore)) 
        ], Title = "Task10", Color = System.Drawing.Color.Coral);
      Chart.Line( 
        [ for i in 1..100..2000 -> 
            (i,time (fun () -> fibN4 i |> ignore)) 
        ], Title = "Task11", Color = System.Drawing.Color.Cyan);
      Chart.Line( 
        [ for i in 1..100..2000 -> 
            (i,time (fun () -> fibN5 i |> ignore)) 
        ], Title = "Task12", Color = System.Drawing.Color.LawnGreen);]


do System.Windows.Forms.Application.Run(gch.ShowChart())