module Task328

open Task31
open Task30
open Task15

let rec main (n : Num) =
    if n = (1, Cons(0, Empty))
    then
        (1, Cons(0, Empty))
    elif n = (1, Cons(1, Empty)) || n = (1, Cons(2, Empty)) 
    then
        (1, Cons(1, Empty))
    else 
        sum
        <| main (sum n (-1, Cons(1, Empty)))  
        <| main (sum n (-1, Cons(2, Empty)))