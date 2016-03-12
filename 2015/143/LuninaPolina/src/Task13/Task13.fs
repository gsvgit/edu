module Task13

let rec fib n = 
    if n < 2 then n
    else fib(n - 1) + fib(n - 2)

let main n = 
    let (outArray : int array) = [|for i in 0..n do yield fib i|]
    outArray