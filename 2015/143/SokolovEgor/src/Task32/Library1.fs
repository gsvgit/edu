module Task32

open Task30
open Task31
open Task15

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

//let fibFrom13 (n : Num) =
//    let outArray = [|1, Cons(1, Empty); 1, Cons(1, Empty)|]
//    let mutable i = 1, Cons(2, Empty)
//    while i.Equals(sum n (-1, Cons(1, Empty))) = false do
//        let ind1 = sum i (-1, Cons(1, Empty))
//        let ind2 = sum i (-1, Cons(2, Empty))
//        outArray.[i] <- sum outArray.[ind1] outArray.[ind2]


