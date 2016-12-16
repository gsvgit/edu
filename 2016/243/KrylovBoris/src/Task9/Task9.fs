module Task9

let main n =
    if n = 1 || n = 0
    then
        1
    elif n > 1
    then
        let mutable FibN = 0
        let mutable fib_1 = 1
        let mutable fib_2 = 1
        let mutable i = 0
        for i in 2..n do
            FibN <- fib_2 + fib_1
            fib_1 <- fib_2
            fib_2 <- FibN
        FibN
    else
        failwith "Invalid number"