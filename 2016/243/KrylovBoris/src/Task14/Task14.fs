module Task14

open FSharp.Charting
open System
open Task8
open Task9
open Task10
open Task11
open Task12
open Task13

let timer f =
    let start = DateTime.Now
    for i in 0..9 do f ()
    (DateTime.Now - start).TotalMilliseconds / 10.0 

let gch =
    Chart.Combine
        [
            Chart.Line( [for i in 0 .. 30 -> (i, timer(fun () -> Task8.main i |> ignore))], "Рекурсивный метод", Color = Drawing.Color.Blue)
            Chart.Line( [for i in 0 .. 100 .. 10000 -> (i, timer(fun () -> Task9.main i |> ignore))], "Итеративный метод", Color = Drawing.Color.Red)
            Chart.Line( [for i in 0 .. 100 .. 10000 -> (i, timer(fun () -> Task10.main i |> ignore))], "Итеративный метод без mutable- и ref-структур", Color = Drawing.Color.Green)
            Chart.Line( [for i in 0 .. 20 .. 2000 -> (i, timer(fun () -> Task11.main i |> ignore))], "Метод перемножения матриц", Color = Drawing.Color.Brown)
            Chart.Line( [for i in 0 .. 100 .. 10000 -> (i, timer(fun () -> Task12.main i |> ignore))], "МПМ за log(O)", Color = Drawing.Color.Lime)
            Chart.Line( [for i in 0 .. 100 .. 10000 -> (i, timer(fun () -> Task13.main i |> ignore))], "Последовательность чисел Фибоначчи", Color = Drawing.Color.Black)
        ]

do System.Windows.Forms.Application.Run(gch.ShowChart())
