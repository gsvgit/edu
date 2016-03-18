module Task13

let main n = 
    let outArray = Array.empty
    for i in 1..n do
        if n < 2 
        then outArray.[n] <- n
        else outArray.[n] <- outArray.[n - 1] + outArray.[n - 2]
    outArray