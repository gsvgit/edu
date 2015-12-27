module Task32

open Task15
open Task30
open Task31

open FSharp.Charting
open System.Drawing
open System.Windows.Forms

let toNum1 () = (1, Cons(1, Empty))
let toNum0 () = (1, Cons(0, Empty))

let ptn (x : Num) = 
    match x with 
    | (s, n) ->
        if s = 1
        then (-1, n)
        else (1, n)

let rec task8FibN (n : Num) =
    if n = toNum1 () || n = (1, Cons(2, Empty))
    then toNum1 ()
    else sum (task8FibN (sum n (-1, Cons(1, Empty))))  (task8FibN (sum n (-1, Cons(2, Empty))))


let task9FibN (n : Num) = 
    let mutable a = toNum1 ()
    let mutable b = toNum1 ()
    let mutable i = (1, Cons(2, Empty))
    while i.Equals(n) = false do
        a <- sum a b 
        b <- sum a (ptn b)
        i <- sum i (toNum1 ())
    a

let task10FibN (n : Num) = 
    let rec fibN n fib1 fib2 i = 
        if n = toNum1 () || n = (1, Cons(2, Empty)) 
        then toNum1 ()
        elif n = i
        then fib1
        else fibN n (sum fib1 fib2) fib1 (sum i (toNum1 ()))
    fibN n (toNum1 ()) (toNum1 ()) (1, Cons(2, Empty))

let task11FibN (n : Num) = 
    let mutable arr1 = [|[|toNum1 (); toNum1 ()|]; [|toNum1 (); toNum0 ()|]|]
    let arr2 = [|[|toNum1 (); toNum1 ()|]; [|toNum1 (); toNum0 ()|]|]
    let mutable e00 = toNum0 ()
    let mutable e01 = toNum0 ()
    let mutable e10 = toNum0 ()
    let mutable e11 = toNum0 ()
    let mutable i = toNum1 ()
    while i.Equals(n) = false do 
        e00 <- sum (multiplication arr1.[0].[0] arr2.[0].[0]) (multiplication arr1.[0].[1] arr2.[1].[0])
        e01 <- sum (multiplication arr1.[0].[0] arr2.[0].[1]) (multiplication arr1.[0].[1] arr2.[1].[1])
        e10 <- sum (multiplication arr1.[1].[0] arr2.[0].[0]) (multiplication arr1.[1].[1] arr2.[1].[0])
        e11 <- sum (multiplication arr1.[1].[0] arr2.[0].[1]) (multiplication arr1.[1].[1] arr2.[1].[1])
        arr1 <- [|[|e00; e01|];[|e10; e11|]|]
        i <- sum i (toNum1 ())
    arr1.[0].[1]

let mod2 (n : Num) = 
    match n with
    | (s, tl) -> 
        let rec lastOf lst =
                match lst with
                | Empty -> 0
                | Cons (hd, Empty) -> hd
                | Cons (hd, tl) -> lastOf tl
        let lst = lastOf tl
        lst % 2 = 0

let rec div2 num i ost =
    match num with
    | s, lst ->
        match lst with
        | Empty -> Empty
        | Cons (n, tl) ->
            if n < 2 
            then 
                if i < 1
                then 
                    div2 (1, tl) (i + 1) n
                else
                    Cons (n / 2, div2 (1, tl) (i + 1) (n % 2))
            else
                if ost > 0 
                then
                    let numOst = ost * 10 + n
                    Cons (numOst / 2, div2 (1, tl) (i + 1) (numOst % 2))
                else
                    Cons (n / 2, div2 (1, tl) (i + 1) (n % 2))

let inInt n =
    match n with
    | s, lst ->
        let rec inInt1 lst res =
            match lst with 
            | Empty -> res
            | Cons (hd, tl) ->
                inInt1 tl (res * 10 + hd)
        s * (inInt1 lst 0)


let matrixMultiply (arr1 : Num[][]) (arr2 : Num[][]) = 
    let e00 = sum (multiplication arr1.[0].[0] arr2.[0].[0]) (multiplication arr1.[0].[1] arr2.[1].[0])
    let e01 = sum (multiplication arr1.[0].[0] arr2.[0].[1]) (multiplication arr1.[0].[1] arr2.[1].[1])
    let e10 = sum (multiplication arr1.[1].[0] arr2.[0].[0]) (multiplication arr1.[1].[1] arr2.[1].[0])
    let e11 = sum (multiplication arr1.[1].[0] arr2.[0].[1]) (multiplication arr1.[1].[1] arr2.[1].[1])
    [|[|e00; e01|];[|e10; e11|]|]



let rec matrixPower arr (n: Num) =
    if n = toNum1 ()
    then arr
    elif mod2 n 
    then 
        let mp = matrixPower arr (1, div2 n 0 0 )
        matrixMultiply mp mp 
    else 
        let mp = matrixPower arr (1, div2 (sum n (-1, Cons(1, Empty))) 0 0 )
        matrixMultiply arr (matrixMultiply mp mp)

let task12FibN n =
    let matrix = [|[|toNum1 (); toNum1 ()|];[|toNum1 (); toNum0 ()|]|] 
    let fibN = matrixPower matrix n
    fibN.[0].[1]

let task13FibN (n : Num) = 
    let outArray : Num array = Array.zeroCreate (inInt n)
    if n = toNum1 ()
    then outArray.[0] <- toNum1 ()
    else
        outArray.[0] <- toNum1 ()
        outArray.[1] <- toNum1 ()
        for i in 2..outArray.Length - 1 do 
            outArray.[i] <-  sum outArray.[i - 1] outArray.[i - 2]
    outArray 


let fromInt n =
    let rec sum result i =
        if i = 0
        then 
            result
        else 
            sum (Cons (i % 10, result)) (i / 10)
    if n > 0
    then 1, sum Empty n
    else -1, sum Empty n

let time f =
    let start = System.DateTime.Now
    for i = 1 to 50 do f()
    (System.DateTime.Now - start).TotalMilliseconds / 50.00

let charting =
    Chart.Combine
        [
             Chart.Line( [ for i in 1..30 -> (i, time(fun () -> task8FibN (fromInt i) |> ignore) ) ], "Task8", Color = System.Drawing.Color.Green)
             Chart.Line( [ for i in 1..10..1000 -> (i, time(fun () -> task9FibN (fromInt i) |> ignore) ) ], "Task9", Color = System.Drawing.Color.Crimson)
             Chart.Line( [ for i in 1..10..1000 -> (i, time(fun () -> task10FibN (fromInt i) |> ignore) ) ], "Task10", Color = System.Drawing.Color.DarkGoldenrod)
             Chart.Line( [ for i in 1..10..1000 -> (i, time(fun () -> task11FibN (fromInt i) |> ignore) ) ], "Task11", Color = System.Drawing.Color.HotPink)
             Chart.Line( [ for i in 1..10..1000 -> (i, time(fun () -> task12FibN (fromInt i) |> ignore) ) ], "Task12", Color = System.Drawing.Color.Maroon)
             Chart.Line( [ for i in 1..10..1000 -> (i, time(fun () -> task13FibN (fromInt i) |> ignore) ) ], "Task13", Color = System.Drawing.Color.MediumTurquoise)
        ]
do System.Windows.Forms.Application.Run(charting.ShowChart())
