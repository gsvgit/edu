module Task10

let main n = 
    let rec fibN n fib1 fib2 i = 
        if n <= 2 
        then 1
        elif n = i
        then fib1
        else fibN n (fib1 + fib2) fib1 (i + 1)
    fibN n 1 1 2