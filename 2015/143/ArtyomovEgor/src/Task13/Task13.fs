module Task13

let inp = System.Console.ReadLine() |> int

let fillArray (inp:int) =
    let arr = Array.zeroCreate inp
    if inp > 1 
    then 
        arr.[0] <- 1
        arr.[1] <- 1
        for i = 2 to inp - 1  do
            arr.[i] <- arr.[i - 1] + arr.[i - 2]
        arr
    else
        [| 1 |]

printfn "%A" (fillArray inp)