module Task29

let from10to2 (x : int64) = 
    let mutable n = x
    let a = Array.zeroCreate 64
    let mutable i = 63
    while n > 0L do
        a.[i] <- n % 2L
        i <- i - 1
        n <- n / 2L
    a

let binRepresent (x : int64) = 
    let mutable n = x
    if n >= 0L 
    then from10to2 x
    else 
        n <- -1L * n
        let mutable temp = from10to2 n
        for i in 0..63 do
            if temp.[i] = 1L
            then 
                temp.[i] <- 0L
            else 
                temp.[i] <- 1L
        let mutable a = 1
        temp <- Array.rev temp
        for i in 0..63 do
            if a = 1 
            then 
                if temp.[i] = 0L
                then 
                    temp.[i] <- 1L
                    a <- 0
                else temp.[i] <- 0L
        temp <- Array.rev temp
        temp

let main n = 
    if n = -9223372036854775808L 
    then 
        let g = [|for i in 0..62 -> 0L|]
        let f = Array.append [|1L|] g
        for i in 0..63 do 
            printfn "%d" f.[i]
    else
        let g = binRepresent n
        for i in 0..63 do
            printf "%d" g.[i]
        printf "\n"

let n = System.Console.ReadLine() |> int64
System.Console.WriteLine(main n)