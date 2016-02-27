module Task4

let main inArray num = 
    let len = Array.length inArray - 1
    let mutable index = 0 
    for i in 0..len do
        if inArray.[i] <= num
        then 
            inArray.[index] <- i
            index <- index + 1
    let outArray = Array.sub inArray 0 index
    outArray