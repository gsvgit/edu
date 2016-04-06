module Task12

let n = System.Console.ReadLine () |> int

let matrixMultiply (arr1 : int[][]) (arr2 : int[][]) = 
    let e00 = arr1.[0].[0] * arr2.[0].[0] + arr1.[0].[1] * arr2.[1].[0]
    let e01 = arr1.[0].[0] * arr2.[0].[1] + arr1.[0].[1] * arr2.[1].[1]
    let e10 = arr1.[1].[0] * arr2.[0].[0] + arr1.[1].[1] * arr2.[1].[0]
    let e11 = arr1.[1].[0] * arr2.[0].[1] + arr1.[1].[1] * arr2.[1].[1]
    [|[|e00; e01|];[|e10; e11|]|]


let rec matrixPower arr n =
    if n = 1 
    then arr
    elif n % 2 = 0 
    then 
        let mp = matrixPower arr (n / 2)
        matrixMultiply mp mp 
    else 
        let mp = matrixPower arr ((n - 1) / 2)
        matrixMultiply arr (matrixMultiply mp mp)

let main n =
    let matrix = [|[|1; 1|];[|1; 0|]|] 
    let fibN = matrixPower matrix n
    fibN.[0].[1]

[<EntryPoint>]
let entry args =
    printfn "%d" (main n)
    0
