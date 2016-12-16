module Task11

let mxmult (A: int[,])(B: int[,]) =
    let a11 = A.[0, 0] * B.[0, 0] + A.[0, 1] * B.[1, 0]
    let a12 = A.[0, 0] * B.[0, 1] + A.[0, 1] * B.[1, 1]
    let a21 = A.[1, 0] * B.[0, 0] + A.[1, 1] * B.[1, 0]
    let a22 = A.[1, 0] * B.[0, 1] + A.[1, 1] * B.[1, 1]
    let out = array2D [[a11; a12]; [a21; a22]]
    out
  
let rec mxpow (A: int[,]) n =
    if (n = 1) || (n = 0) 
    then A
    else mxmult A (mxpow A (n - 1))
       
let main n =
    if n > 0
    then
        let R = array2D [[1; 1]; [1; 0]]
        let res = mxpow R n
        res.[0, 0]
    else
        failwith "Invalid number"