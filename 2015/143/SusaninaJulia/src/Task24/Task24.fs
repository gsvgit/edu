(* 
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
            Chart.Line( [ for i in 1..2..100 -> (i, time(fun () -> Task21.main (myLstRand i) |> ignore) ) ], "Bubblesort in MyList", Color = System.Drawing.Color.Aquamarine)
            Chart.Line( [ for i in 1..2..600 -> (i, time(fun () -> Task22.main (myLstRand i) |> ignore) ) ], "Quicksort in MyList", Color = System.Drawing.Color.Coral)
            Chart.Line( [ for i in 1..2..1600 -> (i, time(fun () -> Task23.main [|for k in 1..i -> rand.Next()|] |> ignore) ) ], "Quicksort in array", Color = System.Drawing.Color.Firebrick)
            Chart.Line( [ for i in 1..2..1500 -> (i, time(fun () -> Array.sort([|for k in 1..i -> rand.Next()|]) |> ignore) ) ], "Array.sort", Color = System.Drawing.Color.Thistle)
            Chart.Line( [ for i in 1..2..1500 -> (i, time(fun () -> List.sort([for k in 1..i ->rand.Next()]) |> ignore) ) ], "List.sort", Color = System.Drawing.Color.DarkSeaGreen)
        ]
do System.Windows.Forms.Application.Run(main.ShowChart())
*)