module Task13

let main n =
    let mutable i = 0
    let outArray: int array = Array.create (n + 1) 0
    if n > 1 
    then 
        outArray.[1] <- 1
        for i in 2 .. n do
            outArray.[i] <- outArray.[i - 2] + outArray.[i - 1]
    outArray