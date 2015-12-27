module Task328

open Task31
open Task30
open Task15

let unit = (1, Cons(1, Empty))
let zero = (1, Cons(0, Empty))
let rec main (n : Num) =
    if n = zero
    then
        zero
    elif n = unit || n = (1, Cons(2, Empty)) 
    then
        unit
    else 
        sum
        <| main (sum n (-1, Cons(1, Empty)))  
        <| main (sum n (-1, Cons(2, Empty)))