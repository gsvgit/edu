module Task3211

open Task31
open Task30
open Task15

let mult (A : Num[,]) (B : Num[,]) = 
    let s00 = sum (Task31.mult A.[0,0] B.[0,0]) (Task31.mult A.[0,1] B.[1,0])
    let s01 = sum (Task31.mult A.[0,0] B.[0,1]) (Task31.mult A.[0,1] B.[1,1])
    let s10 = sum (Task31.mult A.[1,0] B.[0,0]) (Task31.mult A.[1,1] B.[1,0])
    let s11 = sum (Task31.mult A.[1,0] B.[0,1]) (Task31.mult A.[1,1] B.[1,1])
    let C = array2D  [ [ s00; s01 ]; [ s10; s11 ] ]
    C
  
let rec mpower (Arr : Num[,]) (n : Num) =
    if n = (1, Cons(1, Empty)) || n = (1, Cons(0, Empty)) 
    then
        Arr
    else
        mult Arr (mpower Arr (sum n (-1, Cons(1, Empty))))

let main (n : Num) =
    let mtrx = array2D [ [ (1, Cons(1, Empty)); (1, Cons(1, Empty)) ]; [ (1, Cons(1, Empty)); (1, Cons(1, Empty)) ] ]
    let ret = mpower mtrx (sum n (-1, Cons(1, Empty)))
    ret.[0,0]
