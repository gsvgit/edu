module Task32

open FSharp.Charting
open Task15
open Task30
open Task328
open Task329
open Task3210
open Task3211

let task8 (n : Num) = Task328.main n
let task9 (n : Num) = Task329.main n
let task10 (n : Num) = Task3210.main n
let task11 (n : Num) = Task3211.main n
let task12 (n : Num) = Task3212.main n
let task13 (n : Num) = Task3213.main n
let task14 =
    let intToNum (n : int) =
        let rec numer nm (ni : int) =
            if ni = 0
            then
                nm
            else
                numer (Cons(ni % 10, nm)) (ni / 10)
        if n > 0
        then
            (1, numer Empty n)
        else
            (-1, numer Empty n)


    let time f =
        let start = System.DateTime.Now
        for i in 0..9 do f ()
        (System.DateTime.Now - start).TotalMilliseconds / 10.0

    let gch = 
        Chart.Combine
         [Chart.Line( [ for i in 10..5..30 -> (i,time (fun () -> task8 (intToNum i) |> ignore) ) ], "Rec", Color = System.Drawing.Color.Red)
          Chart.Line( [ for i in 1000..100..100000 -> (i,time (fun () -> task9 (intToNum i) |> ignore) ) ], "Iter", Color = System.Drawing.Color.Green)
          Chart.Line( [ for i in 1000..100..100000 -> (i,time (fun () -> task10 (intToNum i) |> ignore) ) ], "Iter without mut", Color = System.Drawing.Color.Blue)
          Chart.Line( [ for i in 1000..100..16000 -> (i,time (fun () -> task11 (intToNum i) |> ignore) ) ], "Matrix", Color = System.Drawing.Color.Black)
          Chart.Line( [ for i in 1000..100..30000 -> (i,time (fun () -> task12 (intToNum i) |> ignore) ) ], "Matrix log", Color = System.Drawing.Color.Gray)
          Chart.Line( [ for i in 1000..100..100000 -> (i,time (fun () -> task13 (intToNum i) |> ignore) ) ], "Array", Color = System.Drawing.Color.Yellow)
         ]


    do System.Windows.Forms.Application.Run(gch.ShowChart())
