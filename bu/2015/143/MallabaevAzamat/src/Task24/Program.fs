module Task24

open Task15
open Task21
open Task22
open System.Drawing
open System.Windows.Forms
open FSharp.Charting

let once_time i f =
  let time_start = System.DateTime.UtcNow
  ignore <| f i
  (System.DateTime.UtcNow - time_start).TotalMilliseconds |> int

let many_time i f =
  let marr = (Array.sort [|for _ in 0..8 -> (once_time i f)|])
  (marr.[0] + marr.[1] * 2 + marr.[2] * 3 + marr.[3] * 5 + marr.[4] * 8 + marr.[5] * 5 + marr.[6] * 3 + marr.[7] * 2 + marr.[8]) / 30

let rand = new System.Random()

let rec gen n = if n <= 0 then Empty else Smth (rand.Next(), gen (n - 1))

let bubbleSort n = Task21.main (gen n)
let hoarSort n = Task22.quickSort (gen n)

[<EntryPoint>]
let entry args =
  printfn "Введите, пожалуйста, верхнюю границу счета чисел"
  let n = System.Console.ReadLine() |> int
  let ``bubbleSort graph`` = Chart.Line (seq {for i in 0..n do yield (i, many_time i bubbleSort)}, Color = Color.Black)
  let ``hoarSort graph`` = Chart.Line (seq {for i in 0..n do yield (i, many_time i hoarSort)}, Color = Color.Red)
  let tasksStat =
    (Chart.Combine(
       [
        ``bubbleSort graph``;
        ``hoarSort graph``
       ]).WithTitle "Tasks time\nbubbleSort - Black\nhoarSort - Red").WithXAxis(Title="N").WithYAxis(Title="milliseconds")
  let window = tasksStat.ShowChart()

  Application.Run(window)

  0
