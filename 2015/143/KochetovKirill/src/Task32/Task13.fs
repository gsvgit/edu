module Task3213

open Task31
open Task30
open Task15

let numToInt (n : Num) = 
    match n with
    |(sign, abs) ->
        let rec listToInt lst sm =
            match lst with 
            | Empty -> sm
            | Cons (head, tail) ->
                listToInt tail (10 * sm + head)
        sign * (listToInt abs 0)

let main (n : Num) = 
    let Fib = Array.create (numToInt n) (1, Cons(1, Empty))
    for i in 2..((numToInt n) - 1) do
        Fib.[i] <- sum Fib.[i - 1] Fib.[i - 2]
    Fib