module Task27
    
let convert n = 
    let mutable tmp = n |> int 
    let mutable arr = [||]
    while tmp > 0 do 
        arr <- Array.append [|tmp % 2|] arr 
        tmp <- tmp / 2
    arr

let getFractional (n : float) = 
    let mutable n1 = floor(n)
    n1 <- n - n1
    if n1 = 0.0
    then
        let arr = Array.zeroCreate 0
        arr
    else
        let order = Array.length (convert n)
        let mutable tmp = 0
        let mutable arr = [||]
        while tmp < (52 - order) do
            n1 <- n1 * 2.0 
            if n1 >= 1.0 
            then 
                n1 <- n1 - 1.0
                arr <- Array.append arr [|1|]
            else 
                arr <- Array.append arr [|0|]
            tmp <- tmp + 1 
        arr

let mantis n =
    let mutable arr = Array.zeroCreate 52
    let div = convert (abs n)
    let modul = getFractional (abs n)
    if (abs n) >= 1.00
    then
        let mutable j = 0
        for i in 1..(div.Length - 1) do
            arr.[j] <- div.[i]
            j <- j + 1
        for i in 0..((modul).Length - 1) do
            arr.[j] <- (modul).[i]
            j <- j + 1
    else
        let mutable j = 0
        let mutable k = 0
        while modul.[j] = 0 do
            j <- j + 1
        for i in (j + 1)..(modul.Length - 1) do
            arr.[k] <- modul.[i]
            k <- k + 1
    arr

let binary n =
    let div = convert (abs n)
    let modul = getFractional (abs n)
    let arr = Array.zeroCreate 64
    if n >= 0.0
    then arr.[0] <- 0
    else arr.[0] <- 1

    let order n =
        if (abs n) >= 1.00
        then
            1023 + div.Length - 1
        else
            let mutable j = 0;
            while modul.[j] = 0 do
                j <- j + 1
            1023 - j - 1

    let ordconv = convert (float(order n))
    let mutable i = ordconv.Length - 1
    for j in 11..-1..(11 - i) do
        arr.[j] <- ordconv.[i]
        i <- i - 1
    i <- 0

    for j in 12..63 do
        arr.[j] <- (mantis n).[i]
        i <- i + 1
    arr

let arraymain n =
    if n = 0.0 
    then
        let res = Array.zeroCreate 64
        res
    else
        let res = binary n
        res


let main n =
    if n = 0.0 
    then
        let res = Array.zeroCreate 64
        for i in 0..63 do
            printf "%d" res.[i]
    else
        let res = binary n
        for i in 0..63 do
            printf "%d" res.[i]

let reading = System.Console.ReadLine() |> float
System.Console.WriteLine(main reading)
let cmdstay = System.Console.ReadKey(true)