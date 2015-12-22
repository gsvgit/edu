//module Task32
//
//open Task31
//open Task30
//open Task15
//
//let rec task8 (n : Num) =
//    if n = (1, Cons(0, Empty))
//    then
//        (1, Cons(0, Empty))
//    elif n = (1, Cons(1, Empty)) || n = (1, Cons(2, Empty)) 
//    then
//        (1, Cons(1, Empty))
//    else 
//        sum
//        <| task8 (sum n (-1, Cons(1, Empty)))  
//        <| task8 (sum n (-1, Cons(2, Empty)))
//
//let task9 (n : Num) =
//    if n = (1, Cons(0, Empty))
//    then
//        (1, Cons(0, Empty))
//    elif n = (1, Cons(1, Empty)) || n = (1, Cons(2, Empty))
//    then
//        (1, Cons(1, Empty))
//    else
//        let mutable c = (1, Cons(1, Empty))
//        let mutable b = (1, Cons(1, Empty))
//        let mutable a = (1, Cons(3, Empty))
//        let mutable d = (1, Cons(0, Empty))
//        while a.Equals(n) = false do
//          d <- sum c b
//          c <- b
//          b <- d         
//          a <- sum a (1, Cons(1, Empty))
//        c
//
//let task10 (n : Num) =
//    let rec next (a : Num) (b : Num) (i : Num) (n : Num) = 
//        if i = n
//        then
//            a
//        else
//            next (sum a b) a (sum i  (1, Cons(1, Empty))) n
//
//    let main (n : Num) =
//        if n = (1, Cons(1, Empty)) 
//        then
//            (1, Cons(1, Empty))
//        else 
//            next 
//            <| (1, Cons(1, Empty)) 
//            <| (1, Cons(1, Empty)) 
//            <| (1, Cons(2, Empty)) 
//            <| n
//    main n
//
//let task11 (n : Num) =
//    let mult (A : Num[,]) (B : Num[,]) = 
//        let s00 = sum (Task31.mult A.[0,0] B.[0,0]) (Task31.mult A.[0,1] B.[1,0])
//        let s01 = sum (Task31.mult A.[0,0] B.[0,1]) (Task31.mult A.[0,1] B.[1,1])
//        let s10 = sum (Task31.mult A.[1,0] B.[0,0]) (Task31.mult A.[1,1] B.[1,0])
//        let s11 = sum (Task31.mult A.[1,0] B.[0,1]) (Task31.mult A.[1,1] B.[1,1])
//        let C = array2D  [ [ s00; s01 ]; [ s10; s11 ] ]
//        C
//  
//    let rec mpower (Arr : Num[,]) (n : Num) =
//        if n = (1, Cons(1, Empty)) || n = (1, Cons(0, Empty)) 
//        then
//            Arr
//        else
//            mult Arr (mpower Arr (sum n (-1, Cons(1, Empty))))
//
//    let main (n : Num) =
//        let mtrx = array2D [ [ (1, Cons(1, Empty)); (1, Cons(1, Empty)) ]; [ (1, Cons(1, Empty)); (1, Cons(1, Empty)) ] ]
//        let ret = mpower mtrx (sum n (-1, Cons(1, Empty)))
//        ret.[0,0]
//    main n
//
//let task12 (n : Num) =
//    let rec Fib (Arr : Num[,]) (n : Num) =
//        if n = 1 || n = 0 then
//            Arr
//        else
//            if n % 2 = 0 then
//            let ret = Task11.mult (Fib Arr (n / 2) ) (Fib Arr (n / 2) )
//            ret
//            else
//            let rc = Task11.mult (Fib Arr ( (n - 1) / 2) ) (Fib Arr ( (n - 1) / 2) )
//            let ret = Task11.mult Arr rc
//            ret
// 
//    let main (n : Num) = 
//        let mtrx = array2D [ [ 1; 1 ] ; [ 1; 0 ] ]
//        let fibn = Fib mtrx (n - 1)
//        fibn.[0,0]
//
//    main n