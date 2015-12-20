module Task24

open FSharp.Charting
open System.Drawing
open System.Windows.Forms
open Task15

let rand = System.Random()
let myLstRand n = 
    let rec get i = 
        if i > 0 
        then
            Cons(rand.Next(), get(i - 1))
        else
            Empty
    get n

let time f =
    let start = System.DateTime.Now
    for i = 1 to 30 do f()
    (System.DateTime.Now - start).TotalMilliseconds / 30.00

let main =
    Chart.Combine
        [
            Chart.Line( [ for i in 1..2..300 -> (i, time(fun () -> Task21.main (myLstRand i) |> ignore) ) ], "MyList", Color = System.Drawing.Color.Black)
            Chart.Line( [ for i in 1..2..600 -> (i, time(fun () -> Task22.main (myLstRand i) |> ignore) ) ], "MyList, quick", Color = System.Drawing.Color.Gray)
            Chart.Line( [ for i in 1..2..1600 -> (i, time(fun () -> Task23.main [|for k in 1..i -> rand.Next()|] |> ignore) ) ], "Array, quick", Color = System.Drawing.Color.Red)
            Chart.Line( [ for i in 1..2..1500 -> (i, time(fun () -> Array.sort([|for k in 1..i -> rand.Next()|]) |> ignore) ) ], "Array, stand", Color = System.Drawing.Color.Aqua)
            Chart.Line( [ for i in 1..2..1500 -> (i, time(fun () -> List.sort([for k in 1..i ->rand.Next()]) |> ignore) ) ], "List, stand", Color = System.Drawing.Color.Brown)
        ]
do System.Windows.Forms.Application.Run(main.ShowChart())