module Task14

open FSharp.Charting

let once_time i f =
  let time_start = System.DateTime.UtcNow
  ignore <| f i
  (System.DateTime.UtcNow - time_start).TotalMilliseconds

let many_time count i f =
  sqrt ((List.sum [for _ in 0..count -> (once_time i f) ** 2.0]) / (float count))

[<EntryPoint>]
let entry args =
  let redo_count = 10
  let fib_graph = Chart.Line([for i in -39..39 -> (i, TaskC.main i)], Title="Fibonacci function").WithXAxis(Title="N").WithYAxis(Title="fib N")
  let ``Task8.main N`` = Chart.Line [for i in -39..39 -> (i, many_time redo_count i Task8.main)]
  let ``Task9.main N`` = Chart.Line [for i in -39..39 -> (i, many_time redo_count i Task9.main)]
  let ``TaskA.main N`` = Chart.Line [for i in -39..39 -> (i, many_time redo_count i TaskA.main)]
  let ``TaskB.main N`` = Chart.Line [for i in -39..39 -> (i, many_time redo_count i TaskB.main)]
  let ``TaskC.main N`` = Chart.Line [for i in -39..39 -> (i, many_time redo_count i TaskC.main)]
  let tasks_stat = (Chart.Combine([``Task8.main N``; ``Task9.main N``; ``TaskA.main N``; ``TaskB.main N``; ``TaskC.main N``]).WithTitle "Tasks time").WithXAxis(Title="N").WithYAxis(Title="milliseconds")
  let Table = Chart.Rows [fib_graph; tasks_stat]
  
  System.Windows.Forms.Application.Run(Table.ShowChart())
  
  0