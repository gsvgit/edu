module Task13

let fib (array:array<int>) n = 
    for i in 2..n do
        array.[i] <- array.[i - 1] + array.[i - 2] 
    array

let main n = 
    let array = [|for i in 0..n - 1 -> 1|]
    if (n > 1) 
    then
        array.[0] <- 1
        array.[1] <- 1
        fib array (n - 1)
    else 
        [|1|]