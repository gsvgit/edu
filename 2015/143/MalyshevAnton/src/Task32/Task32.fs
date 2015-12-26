﻿module Task32

open Task15
open Task30
open Task31
open System.Drawing
open System.Windows.Forms
open FSharp.Charting

let rec fibTask8 (n: Num) =
    if compare (snd n) (snd (1, Cons(2, Empty))) 
    then addition (fibTask8 (addition n (-1, Cons(1, Empty)))) (fibTask8 (addition n (-1, Cons(2, Empty))))
    else n

let fibTask9 (n: Num) =
    if compare (snd n) (snd (1, Cons(2, Empty)))
    then
        let mutable fibN = (1, Cons(0, Empty))  // fibN = fib(n)
        let mutable fibN1 = (1, Cons(1, Empty)) // fibN1 = fib(n-1)
        let mutable fibN2 = (1, Cons(0, Empty)) // fibN2 = fib(n-2)
        let mutable ilong = (1, Cons(2, Empty))
        let mutable i = Cons(2, Empty)
        let list = snd n
        while compare list i do
            fibN <- addition fibN1 fibN2
            fibN2 <- fibN1
            fibN1 <- fibN
            ilong <- addition ilong (1, Cons(1, Empty))
            i <- snd ilong
        fibN
    else n

       
let fibTask10 (n: Num) =

    let rec fib fibN1 fibN2 n s = 
        if compare (snd (addition n (-1, Cons(1, Empty)))) (snd s)
        then fib (addition fibN1 fibN2) fibN1 n (addition s (1, Cons(1, Empty)))
        else fibN1

    let fibFind n =
        if n = (1, Cons(0, Empty)) || n = (1, Cons(1, Empty))
        then n 
        else fib (1, Cons(1, Empty)) (1, Cons(0, Empty)) n (1, Cons(1, Empty))
    fibFind n


let fibTask11 (n: Num) =
    if compare (snd n) (snd (1, Cons(2, Empty)))
    then
        let C = array2D [| [|(1, Cons(0, Empty)); (1, Cons(0, Empty))|]; [|(1, Cons(0, Empty)); (1, Cons(0, Empty))|] |]
        let B = array2D [| [|(1, Cons(1, Empty)); (1, Cons(1, Empty))|]; [|(1, Cons(1, Empty)); (1, Cons(1, Empty))|] |]
        let A = array2D [| [|(1, Cons(1, Empty)); (1, Cons(1, Empty))|]; [|(1, Cons(1, Empty)); (1, Cons(0, Empty))|] |]
        let mutable ilong = (1, Cons(2, Empty))
        let mutable i = Cons(2, Empty)
        let list = snd n
        while compare list i do
            C.[0, 0] <- addition (multiplication B.[0, 0] A.[0, 0]) (multiplication B.[0, 1] A.[1, 0])
            C.[0, 1] <- addition (multiplication B.[0, 0] A.[0, 1]) (multiplication B.[0, 1] A.[1, 1])
            C.[1, 0] <- addition (multiplication B.[1, 0] A.[0, 0]) (multiplication B.[1, 1] A.[1, 0])
            C.[1, 1] <- addition (multiplication B.[1, 0] A.[0, 1]) (multiplication B.[1, 1] A.[1, 1])
            B.[0, 0] <- C.[0, 0]
            B.[0, 1] <- C.[0, 1]
            B.[1, 0] <- C.[1, 0]
            B.[1, 1] <- C.[1, 1]
            ilong <- addition ilong (1, Cons(1, Empty))
            i <- snd ilong
        B.[0, 1]
    else n


let rec isDiv2 ((n, list): Num) =
    match list with
    | Cons (num, Empty) ->
        if num % 2 = 0 
        then 0
        else 1
    | Empty -> 0
    | Cons (num, tail) -> isDiv2 (n, tail)

let div2 (num: Num) =
    let list = reverse (snd (multiplication num (1, Cons(5, Empty))))
    match list with
    | Cons(0, Empty) -> (1, Cons(0, Empty))
    | Cons(5, Empty) -> (1, Cons(1, Empty))
    | Cons(a, tail) -> (1, reverse tail)
    | Empty -> (1, Empty)


let fibTask12 (n: Num) =

    let Matrix = array2D [| [|(1, Cons(1, Empty)); (1, Cons(1, Empty))|]; [|(1, Cons(1, Empty)); (1, Cons(0, Empty))|] |]

    let MatrixMult (A: Num[,]) (B: Num[,]) =
        let c00 = addition (multiplication A.[0, 0] B.[0, 0]) (multiplication A.[0, 1] B.[1, 0])
        let c01 = addition (multiplication A.[0, 0] B.[0, 1]) (multiplication A.[0, 1] B.[1, 1])
        let c10 = addition (multiplication A.[1, 0] B.[0, 0]) (multiplication A.[1, 1] B.[1, 0])
        let c11 = addition (multiplication A.[1, 0] B.[0, 1]) (multiplication A.[1, 1] B.[1, 1])
        let C = array2D [| [|c00; c01|]; [|c10; c11|] |]
        C 

    let rec FindFib n =
        if compare (snd n) (snd (1, Cons(2, Empty)))
        then
            let mutable m = Matrix
            if isDiv2 n = 0
            then
                m <- FindFib (div2 n)
                let MatrxFib = MatrixMult m m
                MatrxFib
            else
                m <- FindFib (div2 (addition n (-1, Cons(1, Empty))))
                let MatrxFib = MatrixMult Matrix (MatrixMult m m)
                MatrxFib
        else
            Matrix

    let fibF n =
        if n = (1, Cons(0, Empty)) || n = (1, Cons(1, Empty))
        then n
        else
            let FinalMatrix = FindFib n
            FinalMatrix.[0, 1]
    fibF n


let toInt (n, list) =
    let rec atInt list res =
        match list with 
        | Empty -> res
        | Cons (head, tail) -> atInt tail (res * 10 + head)
    n * (atInt list 0)

let fromInt n =
    let rec summing result i =
        if i = 0
        then result
        else summing (Cons (i % 10, result)) (i / 10)
    if n > 0
    then (1, summing Empty n)
    else (-1, summing Empty n)


let fibTask13 (n: Num) =
    let nint = toInt n
    if nint = 0 
    then [|(1, Cons(0, Empty))|]
    else 
        if nint = 1 
        then [|(1, Cons(0, Empty)); (1, Cons(1, Empty))|]
        else
            let fib = [|for i in 0..nint -> (1, Cons(0, Empty))|]
            fib.[0] <- (1, Cons(0, Empty))
            fib.[1] <- (1, Cons(1, Empty))
            for i in 2..nint do
                fib.[i] <- addition fib.[i - 1] fib.[i - 2]   
            fib


let time f =
    let start = System.DateTime.UtcNow
    for i in 0..4 do f ()
    (System.DateTime.UtcNow - start).TotalMilliseconds

let gch = 
    Chart.Combine
        [
            Chart.Line( [ for i in 0..5..30 -> (i,time (fun () -> fibTask8 (fromInt i) |> ignore) ) ], Color = System.Drawing.Color.Red) //Рекурсия
            Chart.Line( [ for i in 0..100..1000-> (i,time (fun () -> fibTask9 (fromInt i) |> ignore) ) ], Color = System.Drawing.Color.Lime) //Итеративный метод 
            Chart.Line( [ for i in 0..100..1000 -> (i,time (fun () -> fibTask10 (fromInt i) |> ignore) ) ], Color = System.Drawing.Color.Blue) //Итеративный с рекурсией
            Chart.Line( [ for i in 0..100..500 -> (i,time (fun () -> fibTask11 (fromInt i) |> ignore) ) ], Color = System.Drawing.Color.Orange) //Перемножение матриц
            Chart.Line( [ for i in 0..100..1000 -> (i,time (fun () -> fibTask12 (fromInt i) |> ignore) ) ], Color = System.Drawing.Color.Gold) //Перемножение матриц за логарифм
            Chart.Line( [ for i in 0..100..1000 -> (i,time (fun () -> fibTask13 (fromInt i) |> ignore) ) ], Color = System.Drawing.Color.Black) //Массив
        ]

do System.Windows.Forms.Application.Run(gch.ShowChart())