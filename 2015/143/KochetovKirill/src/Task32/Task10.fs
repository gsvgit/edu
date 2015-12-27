module Task3210

open Task31
open Task30
open Task15

let rec next (a : Num) (b : Num) (i : Num) (n : Num) = 
    if i = n
    then
        a
    else
        next (sum a b) a (sum i  (1, Cons(1, Empty))) n

let main (n : Num) =
    if n = (1, Cons(1, Empty)) 
    then
        (1, Cons(1, Empty))
    else 
        next 
        <| (1, Cons(1, Empty)) 
        <| (1, Cons(1, Empty)) 
        <| (1, Cons(2, Empty)) 
        <| n