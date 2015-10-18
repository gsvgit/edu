module Task10

let nn = System.Console.ReadLine() |> int

let main n = 
    let outArray : int array = Array.zeroCreate (n + 1)
    outArray.[0] <- 1
    outArray.[1] <- 1
    
    let rec fibN i = 
        if n = 0 
        then 1
        elif n = 1 
        then 1
        elif i = n 
        then
             outArray.[i] <- outArray.[i - 1] + outArray.[i - 2]
             outArray.[i - 1]
        else
             outArray.[i] <- outArray.[i - 1] + outArray.[i - 2]
             fibN (i + 1)
    
    fibN 2
  

[<EntryPoint>]
let entry args =
    printfn "%d" (main nn)
    0
