module Task14

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

[<EntryPoint>]
let entry args =
  let fib_graph = Chart.Line(seq {for i in -50..50 -> (i, TaskC.main i)}, Title="Fibonacci function").WithXAxis(Title="N").WithYAxis(Title="fib N")
  let ``Task8.main N graph`` = Chart.Line (seq {for i in -30..30 do yield (i, many_time i Task8.main)}, Color = Color.Black)
  let ``Task9.main N graph`` = Chart.Line (seq {for i in 0..100000..10000000 do yield (i, many_time i Task9.main)}, Color = Color.Gold)
  let ``TaskA.main N graph`` = Chart.Line (seq {for i in 0..100000..10000000 do yield (i, many_time i TaskA.main)}, Color = Color.Green)
  let ``TaskB.main N graph`` = Chart.Line (seq {for i in 0..100000..10000000 do yield (i, many_time i TaskB.main)}, Color = Color.Blue)
  let ``TaskC.main N graph`` = Chart.Line (seq {for i in 0..100000..1000000 do yield (i, many_time i TaskC.main)}, Color = Color.Red)
  let tasks_stat = (Chart.Combine([
     ``Task8.main N graph``;
     ``Task9.main N graph``;
     ``TaskA.main N graph``; 
     ``TaskB.main N graph``; 
     ``TaskC.main N graph``]).WithTitle "Tasks time\n8 - Black, 9 - Gold, 10 - Green, 11 - Blue, 12 - Red").WithXAxis(Title="N").WithYAxis(Title="milliseconds")
  let table = Chart.Rows [fib_graph; tasks_stat]
  let window = table.ShowChart()

  Application.Run(window)
  
  0