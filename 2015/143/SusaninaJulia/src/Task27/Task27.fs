module Task27

let n = System.Console.ReadLine() |> float

let intfrom10to2 n = 
    let mutable nn =  n |> int
    let mutable arr = [||] 
    while nn > 0 do 
        arr <- Array.append [|nn % 2|] arr 
        nn <- nn / 2 
    arr

let fracfrom10to2 (n : float) = 
    let mutable nn = n - floor(n)
    if nn = 0.0
    then
        let arr = Array.zeroCreate 0
        arr
    else
        let intrepr = intfrom10to2 n 
        let order = Array.length intrepr
        let mutable tmp = 0 
        let mutable arr = [||] 
        while tmp < (52 - order) do 
            nn <- nn * 2.0 
            if nn >= 1.0 
            then 
                nn <- nn - 1.0  
                arr <- Array.append arr [|1|]     
            else 
                arr <- Array.append arr [|0|]
            tmp <- tmp + 1 
        arr

let integ n = intfrom10to2 (abs n)
let frac n = fracfrom10to2 (abs n)

let exponent (n : float) =
    if (abs n) >= 1.0
    then
        1023 + (integ n).Length - 1
    else
        let mutable j = 0;
        while (frac n).[j] = 0 do
            j <- j + 1
        1023 - j - 1

let mantis (n : float) =
    let mutable arr = Array.zeroCreate 52
    if (abs n) >= 1.0
    then
        let mutable j = 0
        for i in 1..(integ n).Length - 1 do
            arr.[j] <- (integ n).[i]
            j <- j + 1
        for i in 0..(frac n).Length - 1 do
            arr.[j] <- (frac n).[i]
            j <- j + 1
    else
        let mutable j = 0
        let mutable k = 0
        while (frac n).[j] = 0 do
            j <- j + 1
        for i in (j + 1)..(frac n).Length - 1 do
            arr.[k] <- (frac n).[i]
            k <- k + 1
    arr

let merge n =
    let arr = Array.zeroCreate 64
    arr.[0] <-  if n >= 0.0
                then 0
                else 1
    let f = (exponent n) |> float
    let expArray = intfrom10to2 f
    let mutable i = expArray.Length - 1
    let x = 
        for j in 11..-1..(11 - i) do
            arr.[j] <- expArray.[i]
            i <- i - 1
    i <- 0
    for j in 12..63 do
        arr.[j] <- (mantis n).[i]
        i <- i + 1
    arr

let main n =
    if n = 0.0 
    then 
        let res = Array.zeroCreate 64 
        for i in 0..63 do 
        printf "%d" res.[i] 
    else 
        let res = merge n
        for i in 0..63 do
            printf "%d" res.[i]
System.Console.WriteLine(main n)
let rk = System.Console.ReadKey(true)

let resfortest n = 
    if n = 0.0 
    then Array.zeroCreate 64 
    else merge n