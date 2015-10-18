module Task12

let x = System.Console.ReadLine () |> int

let matrixMultiply (arr1:int[][]) (arr2:int[][]) = 
  let el_00 = arr1.[0].[0] * arr2.[0].[0] + arr1.[0].[1] * arr2.[1].[0]
  let el_01 = arr1.[0].[0] * arr2.[0].[1] + arr1.[0].[1] * arr2.[1].[1]
  let el_10 = arr1.[1].[0] * arr2.[0].[0] + arr1.[1].[1] * arr2.[1].[0]
  let el_11 = arr1.[1].[0] * arr2.[0].[1] + arr1.[1].[1] * arr2.[1].[1]
  [|[|el_00; el_01|];[|el_10; el_11|]|]


let rec matrixPower arr n =
    if n = 1 
    then 
        let fibArr = arr
        fibArr
    elif n % 2 = 0 
    then
        let fibArr = matrixMultiply (matrixPower arr (n/2)) (matrixPower arr (n/2))
        fibArr
    else 
        let fibArr = matrixMultiply arr (matrixMultiply (matrixPower arr ((n-1)/2)) (matrixPower arr ((n-1)/2)))
        fibArr

let main n =
    let matrix = [|[|1;1|];[|1;0|]|] 
    let fibN = matrixPower matrix n
    fibN.[0].[1]

[<EntryPoint>]
let entry args =
    printfn "%d" (main x)
    0
