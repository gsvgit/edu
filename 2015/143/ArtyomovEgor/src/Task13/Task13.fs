module Task13

let inp = System.Console.ReadLine() |> int

let main inp =
    let outArray = Array.zeroCreate inp
    if inp > 1 
    then 
        outArray.[0] <- 1
        outArray.[1] <- 1
        for i = 2 to inp - 1  do
            outArray.[i] <- outArray.[i - 1] + outArray.[i - 2]
    else
        outArray.[0] <- 1
    outArray