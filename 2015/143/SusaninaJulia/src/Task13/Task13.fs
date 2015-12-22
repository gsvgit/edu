module Task13

let n = System.Console.ReadLine() |> int

let main n = 
    let outArray : int array = Array.zeroCreate n
    if n = 1 
    then outArray.[0] <- 1
    else
        outArray.[0] <- 1
        outArray.[1] <- 1
        for i in 2..outArray.Length - 1 do 
            outArray.[i] <- outArray.[i - 1] + outArray.[i - 2]
    outArray 
     

[<EntryPoint>]
let entry args =
    printfn "%A" (main n)
    let rk = System.Console.ReadKey(true)
    0