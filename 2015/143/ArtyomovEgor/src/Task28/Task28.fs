module Task28

let numsys (x: int) len =
    let mutable n = x
    let arr = Array.zeroCreate len
    let mutable i = len - 1
    while n > 0 do
        arr.[i] <- n % 2
        n <- n / 2
        i <- i - 1
    arr 

let binary x len =
    let mutable n = x
    if n >= 0
    then 
        numsys x len
    else
        n <- (-1) * n
        let mutable tmp = numsys n len
        for i in 0..(len - 1) do
            if tmp.[i] = 1
            then tmp.[i] <- 0
            else tmp.[i] <- 1
        let mutable digit = 1
        for i = (len - 1) downto 0 do
            if digit = 1
            then
                if tmp.[i] = 0
                then
                    tmp.[i] <- 1
                    digit <- 0
                else 
                    tmp.[i] <- 0
            if (i = 0) && (digit = 1) 
            then tmp.[i] <- 1
        tmp

let arraymain n =
    binary n 32

let main n =
    let res = binary n 32
    for i in 0..31 do 
        printf "%d" res.[i]