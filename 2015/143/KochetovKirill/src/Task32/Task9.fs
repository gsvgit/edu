module Task329

open Task31
open Task30
open Task15

let main (n : Num) =
    if n = (1, Cons(0, Empty))
    then
        (1, Cons(0, Empty))
    elif n = (1, Cons(1, Empty)) || n = (1, Cons(2, Empty))
    then
        (1, Cons(1, Empty))
    else
        let mutable c = (1, Cons(1, Empty))
        let mutable b = (1, Cons(1, Empty))
        let mutable a = (1, Cons(2, Empty))
        let mutable d = (1, Cons(0, Empty))
        while a.Equals(n) = false do
          d <- c
          c <- sum c b
          b <- d   
          a <- sum a (1, Cons(1, Empty))
        c
