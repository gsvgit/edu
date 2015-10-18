module Task23

//let filter Arr is =
//    [|for i in Arr do
//        if is i 
//        then yield i|]

let main (inArr : array<int>) =
    if inArr.Length < 1
    then
        [||]
    else
        let rec quickSort (Arr : array<int>) =
            if Arr.Length < 1
            then
                [||]
            else
                let h = Arr.[0]
                Array.append
                    (quickSort (Array.filter(fun x -> x < h) Arr)) 
                    (Array.append 
                        (Array.filter(fun x -> x = h) Arr)
                        (quickSort (Array.filter(fun x -> x > h) Arr)))
        quickSort inArr

[<EntryPoint>]
let inter argv = 
    printfn "%A" <| main [|5; 1; 4; 3; 3; 2; 1|]
    let rk = System.Console.ReadKey(true)
    0
