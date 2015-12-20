module Task27

let x = 0.15625
let mutable xx = abs x
let znak =
    if x >= 0.0
    then
        0
    else
        1

let floatfrom10to2 n = 
    let a = n |> int 
    let mutable nn = a 
    let mutable arr = [||] 
    let mutable ind = 0 
    while nn > 0 do 
        arr <- Array.append [|(nn % 2)|] arr 
        nn <- nn / 2 
        ind <- ind + 1 
    arr
    
let intfrom10to2 (n : int) = 
    let a = n |> int 
    let mutable nn = a 
    let mutable arr = [||] 
    let mutable ind = 0 
    while nn > 0 do 
        arr <- Array.append [|(nn % 2)|] arr 
        nn <- nn / 2 
        ind <- ind + 1 
    arr

let fracfrom10to2 (n : float) = 
    let a = n |> int 
    let mutable nn = n - (a |> float) 
    let intrepr = floatfrom10to2 n 
    let order = Array.length(intrepr)
    let mutable tmp = 0 
    let mutable arr = [||] 
    let ind = 22 - order
    let mutable ost = nn 
    while tmp < ind do 
        ost <- ost * 2.0 
        if ost >= 1.0 
        then 
            ost <- ost - 1.0  
            arr <- Array.append arr [|1|]     
        else 
            arr <- Array.append arr [|0|]
        tmp <- tmp + 1 
    arr

let cel = floatfrom10to2 xx
let drob = fracfrom10to2 xx

let poryad =
    if xx > 1.00
    then
        127 + cel.Length - 1
    else
        let mutable j = 0;
        while drob.[j] = 0 do
            j <- j + 1
        127 - j - 1
let mantis =
    let mutable arr = Array.zeroCreate 23
    if xx > 1.00
    then
        let mutable j = 0
        for i in 1..(cel.Length - 1) do
            arr.[j] <- cel.[i]
            j <- j + 1
        for i in 0..(drob.Length - 1) do
            arr.[j] <- drob.[i]
            j <- j + 1
    else
        let mutable j = 0
        let mutable k = 0
        while drob.[j] = 0 do
            j <- j + 1
        for i in (j + 1)..(drob.Length - 1) do
            arr.[k] <- drob.[i]
            k <- k + 1
    arr
let sbor =
    let arr = Array.zeroCreate 32
    arr.[0] <- znak
    let porArray = intfrom10to2 poryad
    let mutable i = porArray.Length - 1
    for j in 8..-1..(8 - i) do
        arr.[j] <- porArray.[i]
        i <- i - 1
    i <- 0
    for j in 9..31 do
        arr.[j] <- mantis.[i]
        i <- i + 1
    arr

let main =
    printf "%A" sbor