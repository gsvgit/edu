module Task23
open Task15

let main (inputArr: array<int>) =
    let len = inputArr.Length
    if len < 1
    then 
        inputArr
    else
        let rec qsort (arr: array<int>) l r =
            let n = arr.[(l + r) / 2]
            let mutable i = l
            let mutable j = r
            while i < j do
                while arr.[i] < n do
                    i <- i + 1
                while arr.[j] > n do
                    j <- j - 1
                if i <= j
                then
                    let x = arr.[i]
                    arr.[i] <- arr.[j]
                    arr.[j] <- x
                    j <- j - 1
                    i <- i + 1
            if l < j 
            then qsort arr l j
            if r > i
            then qsort arr i r
        qsort inputArr 0 (len - 1)
        inputArr