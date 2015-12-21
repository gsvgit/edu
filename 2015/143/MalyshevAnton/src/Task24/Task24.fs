module Task24

open FSharp.Charting
open System.Drawing
open System.Windows.Forms
open Task15

let myListRandom n = 
    let rec get i = 
        if i > 0 
        then Cons(System.Random().Next(), get(i - 1))
        else Empty
    get n

let time f =
    let start = System.DateTime.UtcNow
    for i in 0..9 do f()
    (System.DateTime.UtcNow - start).TotalMilliseconds

let gch =
    Chart.Combine
        [
            Chart.Line( [ for i in 0..10..600 -> (i, time(fun () -> Task21.main (myListRandom i) |> ignore) ) ], Color = System.Drawing.Color.Black)//bubble sort
            Chart.Line( [ for i in 0..10..350 -> (i, time(fun () -> Task22.main (myListRandom i) |> ignore) ) ], Color = System.Drawing.Color.Lime)//qsort on MyList
            Chart.Line( [ for i in 0..10..1300 -> (i, time(fun () -> Task23.main [|for k in 1..i -> System.Random().Next()|] |> ignore) ) ], Color = System.Drawing.Color.Red)//qsort
            Chart.Line( [ for i in 0..10..1300 -> (i, time(fun () -> Array.sort([|for k in 1..i -> System.Random().Next()|]) |> ignore) ) ], Color = System.Drawing.Color.Gold)//standart array.sort
            Chart.Line( [ for i in 0..10..1300 -> (i, time(fun () -> List.sort([for k in 1..i ->System.Random().Next()]) |> ignore) ) ], Color = System.Drawing.Color.Magenta)//standart list.sort
        ]

do System.Windows.Forms.Application.Run(gch.ShowChart())