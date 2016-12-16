module Task32
    
open FSharp.Charting
open System
open Task15
open Task30
open Task31


let IntToNum i =
    let rec numericTrans (n: MyList<int>) i =
        if i = 0
        then 
            n
        else
            numericTrans (Cons(i % 10, n)) (i / 10)
    if i > 0 
    then 
        1, (numericTrans Empty i)
    elif i < 0
    then
        -1, (numericTrans Empty i)
    else 0, Cons(0, Empty)

let mxmult (A: Num[,]) (B: Num[,]) =
    let a11 = Task30.main (multiply A.[0, 0] B.[0, 0]) (multiply A.[0, 1] B.[1, 0])
    let a12 = Task30.main (multiply A.[0, 0] B.[0, 1]) (multiply A.[0, 1] B.[1, 1])
    let a21 = Task30.main (multiply A.[1, 0] B.[0, 0]) (multiply A.[1, 1] B.[1, 0])
    let a22 = Task30.main (multiply A.[1, 0] B.[0, 1]) (multiply A.[1, 1] B.[1, 1])
    let out = array2D [[a11; a12]; [a21; a22]]
    out

let rec fibRec n =
    match n with
    | 0 -> 0, Cons(0, Empty)
    | 1 | 2 -> 1, Cons(1, Empty)
    | _ -> if n > 1 
           then 
              Task30.main (fibRec (n - 1)) (fibRec (n - 2))
           else
               Task30.main (fibRec (n + 1)) (fibRec (n + 2))

let fibIt n = 
    if n < 2 then
        1, Cons(1, Empty)
    else
        let mutable FibN = 0, Cons(0, Empty)
        let mutable fib_1 = 0, Cons(0, Empty)
        let mutable fib_2 = 1, Cons(1, Empty)
        let mutable i = 0
        for i in 2..n do
            FibN <- Task30.main fib_2 fib_1
            fib_1 <- fib_2
            fib_2 <- FibN
        FibN

let fibIt2 n = 
    let rec calc curr k m n = 
        if not(curr = n)
        then 
            calc (curr + 1) (Task30.main m k) k n
        else
            k
    
    if n = 0 then
        0, Cons(0, Empty)
    elif (n = 1) || (n = 2)
    then
        1, Cons(1, Empty)
    else
        calc 2 (1, Cons(1, Empty)) (1, Cons(1, Empty)) n

let fibMat n =     
    let rec mxpow (A: Num[,]) n =
        if (n = 1) || (n = 0) 
        then A
        else mxmult A (mxpow A (n - 1))

    let e = 1, Cons(1, Empty)
    let o = 0, Cons(0, Empty)
    let R = array2D[[e; e]; [e; o]]
    let res = mxpow R n
    res.[1, 0]

let fibMat2 n = 
    let rec mxpow (A: Num[,]) n =
        if n = 1 || n = 0
        then
          A
        else
          let r = mxpow A (n/2)
          if n % 2 = 1
          then
               mxmult A (mxmult r r)
           else
              mxmult r r

    let e = 1, Cons(1, Empty)
    let o = 0, Cons(0, Empty)
    let Fib1 = array2D[[e; e]; [e; o]]
    let FibN = mxpow Fib1 n
    FibN.[1, 0]


let fibArr n =     
    let mutable i = 0
    let outArray: Num array = Array.create (n + 1) (0, Cons(0, Empty))
    if n > 1
    then 
        outArray.[1] <- (1, Cons(1, Empty))
        for i in 2 .. n do
            outArray.[i] <- Task30.main outArray.[i - 2] outArray.[i - 1]
    outArray


let timer f =
    let n = 10
    let start = DateTime.Now
    for i in 0 .. n - 1 do f ()
    (DateTime.Now - start).TotalMilliseconds / float n

let gch =
    Chart.Combine
        [
            Chart.Line( [for i in 0 .. 100 -> (i, timer(fun () -> fibRec i |> ignore))], "Рекурсивный метод", Color = Drawing.Color.Blue)
            Chart.Line( [for i in 0 .. 10 .. 1000 -> (i, timer(fun () -> fibIt i |> ignore))], "Итеративный метод", Color = Drawing.Color.Red)
            Chart.Line( [for i in 0 .. 10 .. 1000 -> (i, timer(fun () -> fibIt2 i |> ignore))], "Итеративный метод без mutable- и ref-структур", Color = Drawing.Color.Green)
            Chart.Line( [for i in 0 .. 50 .. 1000 -> (i, timer(fun () -> fibMat i |> ignore))], "Метод перемножения матриц", Color = Drawing.Color.Brown)
            Chart.Line( [for i in 0 .. 10 .. 1000 -> (i, timer(fun () -> fibMat2 i |> ignore))], "МПМ за log(O)", Color = Drawing.Color.Lime)
            Chart.Line( [for i in 0 .. 10 .. 1000 -> (i, timer(fun () -> fibArr i |> ignore))], "Последовательность чисел Фибоначчи", Color = Drawing.Color.Black)
        ]

do System.Windows.Forms.Application.Run(gch.ShowChart())



