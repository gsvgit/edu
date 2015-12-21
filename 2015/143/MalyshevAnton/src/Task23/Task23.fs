module Task23

let main (arr: array<int>) = 
    let Parttition left right =
        let x = arr.[left]
        let mutable j = left

        for i in (left+1)..right do 
            if arr.[i] <= x
            then
                j <- j + 1
                let cup = arr.[i]
                arr.[i] <- arr.[j]
                arr.[j] <- cup

        let cup = arr.[left]
        arr.[left] <- arr.[j]
        arr.[j] <- cup

        j

    let rec qsort left right =
        if left < right 
        then
            let m = Parttition left right
            (qsort left (m - 1))
            (qsort (m + 1) right)

    qsort 0 (arr.Length - 1)

    arr