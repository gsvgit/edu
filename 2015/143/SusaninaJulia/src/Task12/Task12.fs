module Task12

let nn = System.Console.ReadLine () |> int

let matrix_multiply (arr1:int[][]) (arr2:int[][]) = 
  let el_00 = arr1.[0].[0] * arr2.[0].[0] + arr1.[0].[1] * arr2.[1].[0]
  let el_01 = arr1.[0].[0] * arr2.[0].[1] + arr1.[0].[1] * arr2.[1].[1]
  let el_10 = arr1.[1].[0] * arr2.[0].[0] + arr1.[1].[1] * arr2.[1].[0]
  let el_11 = arr1.[1].[0] * arr2.[0].[1] + arr1.[1].[1] * arr2.[1].[1]
  [|[|el_00;el_01|];[|el_10;el_11|]|]


let rec matrix_power arr (n:int) =
    if n = 1 then 
        let fibArr = arr
        fibArr
    else 
        if n % 2 = 0 then
            let fibArr = matrix_multiply (matrix_power arr (n/2)) (matrix_power arr (n/2))
            fibArr
        else 
            let fibArr = matrix_multiply (arr) (matrix_multiply (matrix_power arr ((n-1)/2)) (matrix_power arr ((n-1)/2)))
            fibArr

let main n =
    let matrix = [|[|1;1|];[|1;0|]|] 
    let fibN = matrix_power matrix n
    fibN.[0].[1]

[<EntryPoint>]
let entry args =
    printfn "%d" (main nn)
    0