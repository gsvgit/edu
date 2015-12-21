module Task23

let main (arr: array<int>) = 
    let Part l r =
        let x = arr.[l]
        let mutable j = l
        for i in l+1..r do 
            if arr.[i] <= x
            then
                j <- j + 1
                let cup = arr.[i]
                arr.[i] <- arr.[j]
                arr.[j] <- cup
        let cup = arr.[l]
        arr.[l] <- arr.[j]
        arr.[j] <- cup
        j

    let rec qsort l r =
        if l < r 
        then
            let m = Part l r
            (qsort l (m - 1))
            (qsort (m + 1) r)

    qsort 0 (arr.Length - 1)
    arr