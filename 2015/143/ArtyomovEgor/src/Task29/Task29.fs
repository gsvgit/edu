module Task29

let numsys (x: int64) len =
    let mutable n = x
    let arr = Array.zeroCreate len
    let mutable i = len - 1
    while n > 0L do
        arr.[i] <- n % 2L
        n <- n / 2L
        i <- i - 1
    arr 

let binary (x: int64) len =
    let mutable n = x
    if n >= 0L
    then numsys x len
    else
        n <- (-1L) * n
        let mutable tmp = numsys n len
        for i in 0..(len - 1) do
            if tmp.[i] = 1L
            then tmp.[i] <- 0L
            else tmp.[i] <- 1L
        let mutable digit = 1
        for i = (len - 1) downto 0 do
            if digit = 1
            then
                if tmp.[i] = 0L
                then
                    tmp.[i] <- 1L
                    digit <- 0
                else tmp.[i] <- 0L
            if (i = 0)&&(digit = 1) then
                tmp.[i] <- 1L
        tmp

let arraymain n =
    binary n 64 

let main n =
    let res = binary n 64 
    for i in 0..63 do 
        printf "%d" res.[i]