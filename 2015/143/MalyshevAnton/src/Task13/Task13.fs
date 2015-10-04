module Task13

let rec fib fib_n1 fib_n2 number s =
    if s = number
    then 
        fib_n1
    else 
        fib (fib_n1 + fib_n2) fib_n1 number (s + 1)

let FindFib number =
    if number < 2 
    then 
        number 
    else
        fib 1 0 number 1

let main n =
    let outArray = [|for i in 0..n -> (f i) |]
    outArray