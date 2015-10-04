module Task9

let main n =
    if n < 2
    then 
        n
    else 
        let mutable fib_n = 0  // fib_n = fib(n)
        let mutable fib_n1 = 1 // fib_n1 = fib(n-1)
        let mutable fib_n2 = 0 // fib_n2 = fib(n-2)
        for i in 2..n do
            fib_n <- fib_n1 + fib_n2
            fib_n2 <- fib_n1
            fib_n1 <- fib_n
        fib_n