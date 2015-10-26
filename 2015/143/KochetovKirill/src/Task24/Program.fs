//module Task24
//open Task15
//open Task21
//open Task22
//open Task23
//open FSharp.Charting
//
//let rand = new System.Random()
//
//let getArr n = [|for i in 0..n -> int <| rand.Next()|]
//let getLst n = [for i in 0..n -> int <| rand.Next()]
//let getMyLst n =
//    let rec getter i =
//        if i > 0
//        then
//            Cons(int <| rand.Next(), getter(i - 1))
//        else
//            MyList<int>.Empty
//    getter n
//
//let time f =
//    let start = System.DateTime.Now
//    for i in 0..9 do f ()
//    (System.DateTime.Now - start).TotalMilliseconds / 10.0
//
//let gch : ChartTypes.GenericChart = 
//    Chart.Combine
//        [ Chart.Line( 
//            [ for i in 10..1000 ->
//                let lst = getMyLst i
//                (i,time (fun () -> Task21.main lst |> ignore)) ]
//                , Color = System.Drawing.Color.Red);
//        Chart.Line( 
//            [ for i in 10..1000 ->
//                let lst = getMyLst i
//                (i,time (fun () -> Task22.main lst |> ignore)) ]
//                , Color = System.Drawing.Color.Green);
//        Chart.Line( 
//            [ for i in 10..1000 ->
//                let arr = getArr i
//                (i,time (fun () -> Task23.main arr |> ignore)) ]
//                , Color = System.Drawing.Color.Blue);
//        Chart.Line( 
//            [ for i in 10..1000 ->
//                let arr = getArr i
//                (i,time (fun () -> Array.sort arr |> ignore)) ]
//                , Color = System.Drawing.Color.Black);
//        Chart.Line(
//            [ for i in 10..1000 ->
//                let lst = getLst i
//                (i,time (fun () -> List.sort lst |> ignore)) ]
//                , Color = System.Drawing.Color.Yellow) ]
//
//
//do System.Windows.Forms.Application.Run(gch.ShowChart())