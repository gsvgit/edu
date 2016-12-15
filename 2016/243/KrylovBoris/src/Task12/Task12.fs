module Task12
  
let rec mxpow (A: int[,]) n =
    if n = 1 || n = 0 
    then
        A
    else
        let r = mxpow A (n / 2)
        if n % 2 = 1 
        then
            Task11.mxmult A (Task11.mxmult r r)
        else
            Task11.mxmult r r
   
let main n =
    let Fib1 = array2D [[1; 1]; [1; 0]]
    let FibN = mxpow Fib1 n
    FibN.[1, 0]