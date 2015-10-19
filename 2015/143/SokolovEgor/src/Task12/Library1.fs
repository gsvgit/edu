module Task12

open Task11

let rec result (array:int[,]) n =
    if n = 1 || n = 0 
    then
        array
    else
        if n % 2 = 0 
        then
            let res = func (result array (n / 2)) (result array (n / 2))
            res
        else
            let rc = func (result array ((n - 1) / 2)) (result array ((n - 1) / 2))
            let res = func array rc
            res
 
let main n = 
    let mt = array2D [ [1; 1]; [1; 0] ]
    let res = result mt (n - 1)
    res.[0,0]