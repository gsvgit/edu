module Task12

let Matrix = array2D [| [|1; 1|]; [|1; 0|] |]
let MatrixMult (A: int[,]) (B: int[,]) =
    let c00 = A.[0, 0] * B.[0, 0] + A.[0, 1] * B.[1, 0]
    let c01 = A.[0, 0] * B.[0, 1] + A.[0, 1] * B.[1, 1]
    let c10 = A.[1, 0] * B.[0, 0] + A.[1, 1] * B.[1, 0]
    let c11 = A.[1, 0] * B.[0, 1] + A.[1, 1] * B.[1, 1]
    let C = array2D [| [|c00; c01|]; [|c10; c11|] |]
    C 

let rec FindFib n =
    if n <= 1
    then
        Matrix
    else
        let mutable m = Matrix
        if n % 2 = 0
        then
            m <- FindFib (n / 2)
            let MatrxFib = MatrixMult m m
            MatrxFib
        else
            m <- FindFib ((n - 1) / 2)
            let MatrxFib = MatrixMult Matrix (MatrixMult m m)
            MatrxFib

let main n =
    if n < 2
    then
        n |> int
    else
        let FinalMatrix = FindFib n
        FinalMatrix.[0, 1]