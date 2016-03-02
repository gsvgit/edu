module Task9

let main n = 
    let mutable a = 0
    let mutable b = 1
    let mutable fibN = 0
    if n < 2 then fibN <- n
    else
        for i in 1..n - 1 do 
            fibN <- a+b
            a <- b
            b <- fibN
    fibN