module Task32

open Task30
open Task31
open Task15
open FSharp.Charting
open System.Drawing
open System.Windows.Forms

let rec fibFrom8 (n : Num) =
    if n = (1, Cons(0, Empty))
    then 1, Cons(0, Empty)
    elif n = (1, Cons(1, Empty)) || n = (1, Cons (2, Empty))
    then 1, Cons(1, Empty)
    else sum (fibFrom8 (sum n (-1, Cons(1, Empty)))) (fibFrom8 (sum n (-1, Cons(2, Empty))))

let fibFrom9 (n : Num) =
    if n = (1, Cons(0, Empty))
    then 1, Cons(0, Empty)
    else
        let mutable first = 1, Cons(1, Empty)
        let mutable second = 1, Cons(1, Empty)
        let mutable result = 1, Cons(0, Empty)
        let mutable i = 1, Cons(2, Empty)
        while i.Equals(n) = false do
            result <- sum first second
            first <- second
            second <- result
            i <- sum i (1, Cons(1, Empty))
        if n = (1, Cons(2, Empty)) || n = (1, Cons(1, Empty)) 
        then first
        else result
let fibFrom10 (n : Num) = 
    let rec fib first second n i =
        if i = n
        then
            first
        else
            fib (sum first second) first n (sum i (1, Cons(1, Empty)))
    if n = (1, Cons(1, Empty))
    then 1, Cons(1, Empty)
    else fib (1, Cons(1, Empty)) (1, Cons(1, Empty)) n (1, Cons(2, Empty)) 

let fibFrom11 (n : Num) = 
    let func (A : Num[,]) (B : Num[,]) = 
        let ar00 = 
            let a0 = A.[0, 0]
            let a1 = A.[0, 1]
            let b0 = B.[0, 0]
            let b1 = B.[1, 0]
            let c = mult a0 b0
            let d = mult a1 b1
            sum c d
            
        let ar01 = 
            let a0 = A.[0, 0]
            let a1 = A.[0, 1]
            let b0 = B.[0, 1]
            let b1 = B.[1, 1]
            let c = mult a0 b0
            let d = mult a1 b1
            sum c d
        
        let ar10 = 
            let a0 = A.[1, 0]
            let a1 = A.[1, 1]
            let b0 = B.[0, 0]
            let b1 = B.[1, 0]
            let c = mult a0 b0
            let d = mult a1 b1
            sum c d
        
        let ar11 = 
            let a0 = A.[1, 0]
            let a1 = A.[1, 1]
            let b0 = B.[0, 1]
            let b1 = B.[1, 1]
            let c = mult a0 b0
            let d = mult a1 b1
            sum c d
        let arrayRes = array2D [ [ar00; ar01]; [ar10; ar11] ]
        arrayRes
    let rec result (A : Num[,]) n =
        if n = (1, Cons(1, Empty)) || n = (1, Cons(0, Empty))
        then A
        else
            let res = func A (result A (sum n (-1, Cons(1, Empty))))
            res
    let mt = array2D [ [(1, Cons(1, Empty)); (1, Cons(1, Empty))]; [(1, Cons(1, Empty)); (1, Cons(0, Empty))] ]
    let res = result mt (sum n (-1, Cons(1, Empty)))
    res.[0, 0]

let rec isDelOn2 list1 =
    match list1 with
    | sign, list ->
        match list with
        | Cons (num, Empty) ->
            if num % 2 = 0 
            then 0
            else 1
        | Empty ->
            0
        | Cons (num, tale) ->
            isDelOn2 (1, tale)

let rec delOn2 list1 iter ost =
    match list1 with
    | sign, list ->
        match list with
        | Empty -> Empty
        | Cons (num, tale) ->
            if num < 2 
            then 
                if iter < 1
                then 
                    delOn2 (1, tale) (iter + 1) num
                else
                    Cons (num / 2, delOn2 (1, tale) (iter + 1) (num % 2))
            else
                if ost > 0 
                then
                    let nost = ost * 10 + num
                    Cons (nost / 2, delOn2 (1, tale) (iter + 1) (nost % 2))
                else
                    Cons (num / 2, delOn2 (1, tale) (iter + 1) (num % 2))

let inInt n =
    match n with
    | sign, list ->
        let rec inInt1 list res =
            match list with 
            | Empty -> res
            | Cons (n1, n2) ->
                inInt1 n2 (res * 10 + n1)
        sign * (inInt1 list 0)

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

let rec fromLstInNum list1 = 1, list1

let fibFrom12 n =
    let func (A : Num[][]) (B : Num[][]) =
        let ar00 = sum (mult A.[0].[0] B.[0].[0]) (mult A.[0].[1] B.[1].[0])
        let ar01 = sum (mult A.[0].[0] B.[0].[1]) (mult A.[0].[1] B.[1].[1])
        let ar10 = sum (mult A.[1].[0] B.[0].[0]) (mult A.[1].[1] B.[1].[0])
        let ar11 = sum (mult A.[1].[0] B.[0].[1]) (mult A.[1].[1] B.[1].[1])
        [|[|ar00; ar01|]; [|ar10; ar11|]|]
    let rec result array n =
        if n = (1, Cons(1, Empty)) || n = (1, Cons(0, Empty))
        then 
            array
        else
            if isDelOn2 n = 0
            then
                let res = result array (1, delOn2 n 0 0)
                func res res
            else
                let summa = sum n (-1, Cons(1, Empty))
                let ins = delOn2 summa 0 0
                let rc = result array (1, ins)
                func array (func rc rc)

    let mt = [|[|1, Cons(1, Empty); 1, Cons(1, Empty)|]; [|1, Cons(1, Empty); 1, Cons (0, Empty)|]|]
    let res = result mt n
    res.[0].[1]

let fibFrom13 n =
    let nInt = inInt n
    let outArray = Array.create nInt (1, Cons(1, Empty))
    for i in 2..(nInt - 1) do
        outArray.[i] <- sum outArray.[i - 1] outArray.[i - 2]
    outArray

let time f =
    let start = System.DateTime.Now
    for i = 1 to 20 do f()
    (System.DateTime.Now - start).TotalMilliseconds / 20.00

 
let charting =
    Chart.Combine
        [
             Chart.Line( [ for i in 10..2..30 -> (i, time(fun () -> fibFrom8 (fromInt i) |> ignore) ) ], "Rec. method", Color = System.Drawing.Color.Black)
             Chart.Line( [ for i in 1..1000..100000 -> (i, time(fun () -> fibFrom9 (fromInt i) |> ignore) ) ], "Iter. method", Color = System.Drawing.Color.Gold)
             Chart.Line( [ for i in 1..1000..90000 -> (i, time(fun () -> fibFrom10 (fromInt i) |> ignore) ) ], "Iter. method without mutable", Color = System.Drawing.Color.Gray)
             Chart.Line( [ for i in 1..1000..10000 -> (i, time(fun () -> fibFrom11 (fromInt i) |> ignore) ) ], "Matrix, easy method", Color = System.Drawing.Color.Blue)
             Chart.Line( [ for i in 1..1000..100000 -> (i, time(fun () -> fibFrom12 (fromInt i) |> ignore) ) ], "Matrix, log", Color = System.Drawing.Color.Green)
             Chart.Line( [ for i in 1..1000..100000 -> (i, time(fun () -> fibFrom13 (fromInt i) |> ignore) ) ], "Array", Color = System.Drawing.Color.Red)
        ]
do System.Windows.Forms.Application.Run(charting.ShowChart())