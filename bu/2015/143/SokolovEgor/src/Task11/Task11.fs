module Task11

let func (A:int[,]) (B:int[,]) =
    let ar00 = A.[0,0] * B.[0,0] + A.[0,1] * B.[1,0]
    let ar01 = A.[0,0] * B.[0,1] + A.[0,1] * B.[1,1]
    let ar10 = A.[1,0] * B.[0,0] + A.[1,1] * B.[1,0]
    let ar11 = A.[1,0] * B.[0,1] + A.[1,1] * B.[1,1]
    let arrayRes = array2D [ [ar00; ar01]; [ar10; ar11] ]
    arrayRes

let rec result (A:int[,]) n = 
    if n = 1 || n = 0 
    then 
        A
    else 
        let res = func A (result A (n - 1))
        res

let main n = 
    let mt = array2D [ [1; 1]; [1; 0] ]
    let res = result mt (n - 1)
    res.[0,0]
