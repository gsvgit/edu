module Task13

let main n = 
    let outArray = Array.create n 1
    for i in 2..(n - 1) do
        outArray.[i] <- outArray.[i - 1] + outArray.[i - 2] 
    outArray