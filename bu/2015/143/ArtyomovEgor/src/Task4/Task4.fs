module Task4

let main inArray num = 
    let mutable answer = 0 

    for i in 0..(Array.length inArray - 1) do
        if inArray.[i] <= num
        then 
            inArray.[answer] <- i
            answer <- answer + 1

    let outArray: int array = Array.sub inArray 0 answer
    outArray