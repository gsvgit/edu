module Task24

open Task15
open Task21
open Task22
open Task23
open FSharp.Charting
open System.Drawing
open System.Windows.Forms

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
            Chart.Line( [ for i in 0..100..600 -> (i, time(fun () -> Task21.main (myListRandom i) |> ignore) ) ], "bubblelsort", Color = System.Drawing.Color.Black) 
            Chart.Line( [ for i in 0..100..350 -> (i, time(fun () -> Task22.main (myListRandom i) |> ignore) ) ], "qsort MyList", Color = System.Drawing.Color.Lime) 
            Chart.Line( [ for i in 0..100..1300 -> (i, time(fun () -> Task23.main [|for k in 1..i -> System.Random().Next()|] |> ignore) ) ], "qsort ", Color = System.Drawing.Color.Red) 
            Chart.Line( [ for i in 0..100..1300 -> (i, time(fun () -> Array.sort([|for k in 1..i -> System.Random().Next()|]) |> ignore) ) ], "array sort", Color = System.Drawing.Color.Gold) 
            Chart.Line( [ for i in 0..100..1300 -> (i, time(fun () -> List.sort([for k in 1..i ->System.Random().Next()]) |> ignore) ) ], "list sort", Color = System.Drawing.Color.Magenta) 
        ]

do System.Windows.Forms.Application.Run(gch.ShowChart())