module Task28

let trans x = 
    let mutable n = x
    let a = Array.zeroCreate 32
    let mutable i = 31
    while n > 0 do      
        a.[i] <- n % 2
        i <- i - 1
        n <- n / 2
    a

let pres x = 
    let mutable n = x
    if n >= 0 
    then trans x
    else 
        n <- -1 * n
        let mutable temp = trans n
        for i in 0..31 do
            if temp.[i] = 1 
            then 
                temp.[i] <- 0
            else 
                temp.[i] <- 1
        let mutable a = 1
        temp <- Array.rev temp
        for i in 0..31 do
            if a = 1 
            then 
                if temp.[i] = 0
                then 
                    temp.[i] <- 1
                    a <- 0
                else temp.[i] <- 0
        temp <- Array.rev temp
        temp

let result n =
    if n = -2147483648 
    then
        let g = [|for i in 0..30 -> 0|]
        Array.append [|1|] g
    else
        pres n

let main n = 
    if n = -2147483648 
    then 
        let g = [|for i in 0..30 -> 0|]
        let f = Array.append [|1|] g
        for i in 0..31 do 
            printfn "%d" f.[i]
    else
        let g = pres n
        for i in 0..31 do
            printf "%d" g.[i]
        printf "\n"
let reading = System.Console.ReadLine() |> int
System.Console.WriteLine(main reading)