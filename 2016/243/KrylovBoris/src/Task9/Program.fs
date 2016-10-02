module Task9

  let main n =
    if n < 2 then
        n
    else
        let mutable FibN = 0
        let mutable fib_1 = 0
        let mutable fib_2 = 1
        let mutable i = 0
        for i in 2..n do
            FibN <- fib_2 + fib_1
            fib_1 <- fib_2
            fib_2 <- FibN
        FibN