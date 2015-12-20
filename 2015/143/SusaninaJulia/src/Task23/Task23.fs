module Task23
   
let main arr =     
    let swap (arr : array<int>) a b = 
        let tmp = arr.[a]
        arr.[a] <- arr.[b]
        arr.[b] <- tmp
    let qsInPlace arr =
        let rec qs (arr : array<int>) left right = 
            if left < right 
            then 
                let ind = (left + right) / 2 
                let sep = 
                    let pivot = arr.[ind]
                    swap arr ind right
                    let mutable j = left
                    for i in left..(right - 1) do
                        if arr.[i] <= pivot 
                        then 
                            swap arr i j
                            j <- j + 1
                    swap arr j right
                    j                  
                sep |> ignore
                qs arr left (sep - 1)
                qs arr (sep + 1) right
        qs arr 0 (arr.Length - 1)
        arr
    qsInPlace  arr
