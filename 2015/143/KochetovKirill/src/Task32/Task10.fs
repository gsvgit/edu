module Task3210

open Task31
open Task30
open Task15

let unit = (1, Cons(1, Empty))
let rec next (a : Num) (b : Num) (i : Num) (n : Num) = 
    if i = n
    then
        a
    else
        next (sum a b) a (sum i  unit) n

let main (n : Num) =
    if n = unit 
    then
        unit
    else 
        next 
        <| unit 
        <| unit 
        <| (1, Cons(2, Empty)) 
        <| n