module Task13

let main n =
    let outArray = Array.zeroCreate n
    if n > 1 
    then 
        outArray.[0] <- 1
        outArray.[1] <- 1
        for i = 2 to n - 1  do
            outArray.[i] <- outArray.[i - 1] + outArray.[i - 2]
    else
        outArray.[0] <- 1
    outArray