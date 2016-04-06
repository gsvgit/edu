module Task3213

open Task31
open Task30
open Task15
open Task3211

let numToInt (n : Num) = 
    match n with
    |(sign, abs) ->
        let rec listToInt lst sm k =
            match lst with 
            | Empty -> sm
            | Cons (head, tail) ->
                listToInt tail (sm + k * head) (k * 10)
        sign * (listToInt abs 0 1)

let main (n : Num) = 
    let Fib = Array.create (numToInt n) unit
    for i in 2..((numToInt n) - 1) do
        Fib.[i] <- sum Fib.[i - 1] Fib.[i - 2]
    Fib