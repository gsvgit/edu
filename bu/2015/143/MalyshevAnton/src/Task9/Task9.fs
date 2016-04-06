module Task9

let main n =
    if n < 2
    then 
        n
    else 
        let mutable fibN = 0  // fibN = fib(n)
        let mutable fibN1 = 1 // fibN1 = fib(n-1)
        let mutable fibN2 = 0 // fibN2 = fib(n-2)
        for i in 2..n do
            fibN <- fibN1 + fibN2
            fibN2 <- fibN1
            fibN1 <- fibN
        fibN