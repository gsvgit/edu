module Task12

open Task11

let rec Result (Array:int[,]) n =
    if n = 1 || n = 0 
    then
        Array
    else
        if n % 2 = 0 
        then
            let res = func (Result Array (n / 2)) (Result Array (n / 2))
            res
        else
            let rc = func (Result Array ((n - 1) / 2)) (Result Array ((n - 1) / 2))
            let res = func Array rc
            res
 
let main n = 
    let mt = array2D [ [1; 1]; [1; 0] ]
    let res = Result mt (n - 1)
    res.[0,0]