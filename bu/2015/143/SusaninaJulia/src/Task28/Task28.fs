module Task28

let from10to2 x = 
    let mutable n = x
    let arr = Array.zeroCreate 32
    let mutable i = 31
    while n > 0 do      
        arr.[i] <- n % 2
        n <- n / 2
        i <- i - 1
    arr

let binRepresent x = 
    let mutable n = x
    if n >= 0 
    then from10to2 x
    else 
        n <- (-1) * n
        let mutable tmp = from10to2 x
        for i in 0..31 do
            if tmp.[i] = 1 
            then tmp.[i] <- 0
            else tmp.[i] <- 1
        let mutable a = 1
        tmp <- Array.rev(tmp)
        for i in 0..31 do
            if a = 1 
            then 
                if tmp.[i] = 0
                then 
                    tmp.[i] <- 1
                    a <- 0
                else tmp.[i] <- 0
        tmp <- Array.rev(tmp)
        tmp

let main n = 
    if n = -2147483648 
    then 
        let g = [|for i in 0..30 -> 0|]
        let f = Array.append [|1|] g
        for i in 0..31 do 
            printfn "%d" f.[i]
    else
        let g = binRepresent n
        for i in 0..31 do
            printf "%d" g.[i]
        printf "\n"
let n = System.Console.ReadLine() |> int
System.Console.WriteLine(main n)


let resfortest n = 
    if n = -2147483648 
    then 
        let g = [|for i in 0..30 -> 0|]
        Array.append [|1|] g
    else binRepresent n