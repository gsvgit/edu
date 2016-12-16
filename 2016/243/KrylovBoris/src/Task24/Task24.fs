module Task24

open FSharp.Charting
open System
open Task15
open Task21
open Task22
open Task23

let random = new Random()

let timer f =
    let n = 10
    let start = DateTime.Now
    for i in 0 .. n - 1 do f ()
    (DateTime.Now - start).TotalMilliseconds / float n

let ArrayGenerator length =
     Array.init length (fun i -> int(random.NextDouble() * 50.0 - 25.0))

let rec ListGenerator (lst: MyList<int>) length =
    match length with
    |0 -> lst
    |_ ->
        let x = int(random.NextDouble() * 50.0 - 25.0) 
        ListGenerator (Cons(x, lst)) (length - 1)

let gch =
    Chart.Combine
        [
            Chart.Line( [for i in 0 .. 100 -> (i, timer(fun () -> Task21.main (ListGenerator Empty i) |> ignore))], "Сортировка пузырьком", Color = Drawing.Color.Blue)
            Chart.Line( [for i in 0 .. 100 -> (i, timer(fun () -> Task22.main (ListGenerator Empty i) |> ignore))], "Сортировка Хоара на MyList", Color = Drawing.Color.Red)
            Chart.Line( [for i in 0 .. 100 -> (i, timer(fun () -> Task23.main (ArrayGenerator i) |> ignore))], "Сортировка Хоара на массивах", Color = Drawing.Color.Green)
        ]

do System.Windows.Forms.Application.Run(gch.ShowChart())
