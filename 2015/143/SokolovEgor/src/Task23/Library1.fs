module Task23

let swap i j (a:array<int>) =
    let temp = a.[j]
    a.[j] <- a.[i]
    a.[i] <- temp

let partition (a:array<int>) l r piv = 
    let pivot = a.[piv]
    swap piv r a
    let mutable st = l
    for i = l to r - 1 do
        if a.[i] <= pivot
        then
            swap i st a
            st <- st + 1
    swap st r a
    st

let quickSort (a:array<int>) =
    let rec loop (a:array<int>) l r =
        if l < r 
        then
            let piv = (l + r) / 2
            let pivotN = partition a l r piv
            loop a l (pivotN - 1)
            loop a (pivotN + 1) r
    loop a 0 (a.Length - 1)
    a

let main a =
    quickSort a