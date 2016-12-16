module Task13

let main n =
    let mutable i = 0
    if n > 1
    then
        let outArray: int array = Array.create (n + 1) 1 
        outArray.[1] <- 1
        for i in 2 .. n do
            outArray.[i] <- outArray.[i - 2] + outArray.[i - 1]
        outArray
    else
        [|1|]