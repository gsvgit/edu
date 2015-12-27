module Task329

open Task31
open Task30
open Task15

let unit = (1, Cons(1, Empty))
let zero = (1, Cons(0, Empty))
let main (n : Num) =
    if n = zero
    then
        zero
    elif n = unit || n = unit
    then
        unit
    else
        let mutable c = unit
        let mutable b = unit
        let mutable a = (1, Cons(2, Empty))
        let mutable d = unit
        while a.Equals(n) = false do
          d <- c
          c <- sum c b
          b <- d   
          a <- sum a unit
        c
