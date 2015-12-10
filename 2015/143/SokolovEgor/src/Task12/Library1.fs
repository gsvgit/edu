module Task12

let func (A:int[][]) (B:int[][]) =
    let ar00 = A.[0].[0] * B.[0].[0] + A.[0].[1] * B.[1].[0]
    let ar01 = A.[0].[0] * B.[0].[1] + A.[0].[1] * B.[1].[1]
    let ar10 = A.[1].[0] * B.[0].[0] + A.[1].[1] * B.[1].[0]
    let ar11 = A.[1].[0] * B.[0].[1] + A.[1].[1] * B.[1].[1]
    [|[|ar00; ar01|]; [|ar10; ar11|]|]
    

let rec result array n =
    if n = 1 || n = 0 
    then
        array
    else
        if n % 2 = 0 
        then
            let res = result array (n / 2)
            func res res
        else
            let rc = result array ((n - 1) / 2)
            func array (func rc rc)
 
let main n = 
    let mt = [|[|1; 1|]; [|1; 0|]|] 
    let res = result mt n
    res.[0].[1]