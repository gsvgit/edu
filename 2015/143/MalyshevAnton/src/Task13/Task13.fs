module Task13

let rec fib fib_n1 fib_n2 FibNumber s =
    if s = FibNumber
    then 
        fib_n1
    else 
        fib (fib_n1 + fib_n2) fib_n1 FibNumber (s + 1)

let SomeFun FibNumber =
    if FibNumber < 2 then FibNumber else
        fib 1 0 FibNumber 1

let main n =
    let outArray: int array = [|for i in 0..n -> (SomeFun i) |]
    outArray