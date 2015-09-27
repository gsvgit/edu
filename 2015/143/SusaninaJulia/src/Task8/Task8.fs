module Task8

let n = System.Console.ReadLine() |> int

let main n = 
    let rec fibN n =
        if n <= 2 then 1
        else fibN (n - 1) + fibN (n - 2)
    fibN n

[<EntryPoint>]
let entry args =
    printfn "%d" (main n)
    0