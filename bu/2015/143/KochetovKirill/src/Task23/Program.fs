module Task23

let main (inArr : array<int>) =
    if inArr.Length < 1
    then
        [||]
    else
        let rec quickSort (Arr : array<int>) (l : int) (h : int) =
            let x = Arr.[(l + h) / 2]
            let mutable i = l
            let mutable j = h
            while i < j do
                while Arr.[i] < x do 
                    i <- i + 1
                while Arr.[j] > x do 
                    j <- j - 1
                if i <= j 
                then
                    let t = Arr.[j]
                    Arr.[j] <- Arr.[i]
                    Arr.[i] <- t
                    i <- i + 1
                    j <- j - 1
            if l < j 
            then quickSort Arr l j
            if i < h 
            then quickSort Arr i h
        quickSort inArr 0 (inArr.Length - 1)
        inArr

[<EntryPoint>]
let inter argv = 
    printfn "%A" <| main [|3;6;5;8;1;9;2|]
    let rk = System.Console.ReadKey(true)
    0