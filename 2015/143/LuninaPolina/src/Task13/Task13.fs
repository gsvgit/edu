module Task13

let main n = 
    let outArray: int array = Array.zeroCreate (n + 1)
    for i in 0..n do
        if i < 2 
        then outArray.[i] <- i
        else outArray.[i] <- outArray.[i - 1] + outArray.[i - 2]
    outArray