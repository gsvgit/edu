module Task11

let n = System.Console.ReadLine() |> int

let main n = 
    let mutable arr1 = [|[|1; 1|]; [|1; 0|]|]
    let arr2 = [|[|1; 1|]; [|1; 0|]|]
    let mutable e00 = 0
    let mutable e01 = 0
    let mutable e10 = 0
    let mutable e11 = 0
    for i in 1..n - 1 do 
        e00 <- arr1.[0].[0] * arr2.[0].[0] + arr1.[0].[1] * arr2.[1].[0]
        e01 <- arr1.[0].[0] * arr2.[0].[1] + arr1.[0].[1] * arr2.[1].[1]
        e10 <- arr1.[1].[0] * arr2.[0].[0] + arr1.[1].[1] * arr2.[1].[0]
        e11 <- arr1.[1].[0] * arr2.[0].[1] + arr1.[1].[1] * arr2.[1].[1]
        arr1 <- [|[|e00; e01|];[|e10; e11|]|]
    arr1.[0].[1]
            
[<EntryPoint>]
let entry args =
    printfn "%d" (main n)
    0
