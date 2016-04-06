module FSPart

open Task15
open Task30
open Task31
open Task32
open System.Drawing
open System.Windows.Forms
open FSharp.Charting

type 'a MyList = 'a l__MyList
type Num = l__Num

let rec fib1 n =
  match n with
  | Pos Empty -> toNum 0
  | Pos (Smth (_, Empty))
  | Pos (Smth (_, Smth (_, Empty))) -> toNum 1
  | x -> sum (fib1 (dec x)) (fib1 (dec (dec x)))

let fib2 n =
  match n with
  | Pos Empty | Neg Empty -> toNum 0
  | _ ->
    let mutable fibN2 = toNum 0
    let mutable fibN1 = toNum 1

    match n with
    | Pos _ ->
      let mutable i = dec (dec (dec n))
      while isPos i do
        let fibN = sum fibN2 fibN1
        fibN2 <- fibN1
        fibN1 <- fibN
        i <- dec i

    | Neg _ ->
      let mutable i = dec (dec (dec (un n)))
      while isPos i do
        let fibN = sum fibN2 fibN1
        fibN2 <- fibN1
        fibN1 <- fibN
        i <- dec i

    fibN1

let fib3 n =
  let rec fib n f1 f2 i =
    match n with
    | Pos _ ->
      match sum i (un n) with
      | Pos Empty | Neg Empty -> sum f1 f2
      | _ -> fib n (sum f1 f2) f1 (inc i)
    | Neg _ ->
      match sum i n with
      | Pos Empty | Neg Empty -> sum (un f1) f2
      | _ -> fib n (sum (un f1) f2) f1 (inc i)

  match n with
  | Pos Empty | Neg Empty -> toNum 0
  | Pos (Smth ((), Empty)) | Neg (Smth ((), Empty)) -> toNum 1
  | _ -> fib n (toNum 0) (toNum 1) (toNum 1)

type 'a simmat = 'a array

let fib4 n =
  let rec mul (a:Num simmat) (n:Num) =
    if n = toNum 1 then toNum 1
    else if n = toNum 2 then toNum 1
    else
      let mutable i = dec (dec (dec (dec n)))
      while isPos i do
        a.[2] <- a.[1]
        a.[1] <- a.[0]
        a.[0] <- sum a.[1] a.[2]
        i <- dec i
      a.[0]

  match n with
  | Pos Empty | Neg Empty -> toNum 0
  | Pos _ -> (mul [|toNum 1; toNum 1; toNum 0|] n)
  | Neg _ -> if isDivBy2 n then un (mul [|toNum 1; toNum 1; toNum 0|] (un n)) else (mul [|toNum 1; toNum 1; toNum 0|] (un n))

let fib6 n =
  match n with
  | Pos Empty
  | Neg Empty -> [|toNum 0|]
  | Pos (Smth ((), Empty))
  | Neg (Smth ((), Empty)) -> [|toNum 0; toNum 1|]
  | Pos _ ->
    let fib = [|
      let mutable i = dec n
      while isPos n do
        yield Pos Empty
    |]
    fib.[0] <- toNum 0
    fib.[1] <- toNum 1
    for i in 2..(fib.Length - 1) do
      fib.[i] <- sum fib.[i - 1] fib.[i - 2]
    fib
  | Neg _ ->
    let fib = [|
      let mutable i = dec (un n)
      while isPos n do
        yield Pos Empty
    |]
    fib.[0] <- toNum 0
    fib.[1] <- toNum 1
    for i in 2..(fib.Length - 1) do
      fib.[i] <- sum (un fib.[i - 1]) fib.[i - 2]
    fib

let rec div2 n =
  match n with
  | Pos Empty
  | Neg Empty
  | Pos (Smth ((), Empty)) -> Pos Empty
  | Pos _ -> inc (div2 (dec (dec n)))
  | Neg _ -> dec (div2 (inc (inc n)))

let powN (a:Num simmat) (n: Num) =
    let mutable i = n
    let mutable ops = []
    let mutable isExit = true
    while isExit do
      match i with
      | Pos Empty
      | Neg _ -> isExit <- false
      | Pos (Smth (_, Empty)) -> isExit <- false
      | _ ->
        if isDivBy2 i then
          ops <- false :: ops
          i <- div2 i
        else
          ops <- true :: ops
          i <- dec i
    
    for it in ops do
      if it then
        a.[2] <- a.[1]
        a.[1] <- a.[0]
        a.[0] <- sum a.[1] a.[2]
      else
        let keep = sum a.[0] a.[2]
        a.[2] <- sum (mul a.[2] a.[2]) (mul a.[1] a.[1])
        a.[0] <- sum (mul a.[0] a.[0]) (mul a.[1] a.[1])
        a.[1] <- mul keep a.[1]
    a.[1]

let fib5 (n: Num) =
  match n with
  | Pos Empty
  | Neg Empty -> Pos Empty
  | _ ->
    let a = [|toNum 1; toNum 1; toNum 0|]
    match n with
    | Pos _ -> powN a n
    | Neg _ -> if isDivBy2 n then powN a (un n) else un (powN a (un n))

let once_time i f =
  let time_start = System.DateTime.UtcNow
  ignore <| f (toNum i)
  (System.DateTime.UtcNow - time_start).TotalMilliseconds |> int

let many_time i f =
  let marr = (Array.sort [|for _ in 0..8 -> (once_time i f)|])
  (marr.[0] + marr.[1] * 2 + marr.[2] * 3 + marr.[3] * 5 + marr.[4] * 8 + marr.[5] * 5 + marr.[6] * 3 + marr.[7] * 2 + marr.[8]) / 30

let rec toInt n =
  match n with
  | Pos Empty | Neg Empty -> 0
  | Pos _ -> 1 + toInt (dec n)
  | Neg _ -> - 1 + toInt (inc n)

[<EntryPoint>]
let entry args =
  printfn "Введите, пожалуйста, верхнюю границу счета чисел"
  let n = System.Console.ReadLine() |> int
  let fib_graph = Chart.Line(seq {for i in 0..n -> (i, toInt (fib4 (toNum i)))}, Title="Fibonacci function").WithXAxis(Title="N").WithYAxis(Title="fib N")
  let ``fib1 N graph`` = Chart.Line (seq {for i in 0..n do yield (i, many_time i fib1)}, Color = Color.Black)
  let ``fib2 N graph`` = Chart.Line (seq {for i in 0..n do yield (i, many_time i fib2)}, Color = Color.Gold)
  let ``fib3 N graph`` = Chart.Line (seq {for i in 0..n do yield (i, many_time i fib3)}, Color = Color.Green)
  let ``fib4 N graph`` = Chart.Line (seq {for i in 0..n do yield (i, many_time i fib4)}, Color = Color.Blue)
  let ``fib5 N graph`` = Chart.Line (seq {for i in 0..n do yield (i, many_time i fib5)}, Color = Color.Red)
  let tasks_stat =
    (Chart.Combine(
       [
        ``fib1 N graph``;
        ``fib2 N graph``;
        ``fib3 N graph``;
        ``fib4 N graph``;
        ``fib5 N graph``
       ]).WithTitle "Tasks time\n8 - Black, 9 - Gold, 10 - Green, 11 - Blue, 12 - Red").WithXAxis(Title="N").WithYAxis(Title="milliseconds")
  let table = Chart.Rows [fib_graph; tasks_stat]
  let window = table.ShowChart()

  Application.Run(window)

  0
