module Task11

let n = System.Console.ReadLine() |> int

let main n = 
    let arr1 = [|[|1; 1|]; [|1; 0|]|]
    let arr2 = [|[|1; 1|]; [|1; 0|]|]
    for i in 1..n-1 do 
        let el_00 = arr1.[0].[0] * arr2.[0].[0] + arr1.[0].[1] * arr2.[1].[0]
        let el_01 = arr1.[0].[0] * arr2.[0].[1] + arr1.[0].[1] * arr2.[1].[1]
        let el_10 = arr1.[1].[0] * arr2.[0].[0] + arr1.[1].[1] * arr2.[1].[0]
        let el_11 = arr1.[1].[0] * arr2.[0].[1] + arr1.[1].[1] * arr2.[1].[1]
        let arr3 = [|[|el_00; el_01|];[|el_10; el_11|]|]
        
        arr1.[0].[0] <- arr3.[0].[0]
        arr1.[0].[1] <- arr3.[0].[1]
        arr1.[1].[0] <- arr3.[1].[0]
        arr1.[1].[1] <- arr3.[1].[1]
    arr1.[0].[1]
            
[<EntryPoint>]
let entry args =
    printfn "%d" (main n)
    0
