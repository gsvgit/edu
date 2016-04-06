module Task3

let x = System.Console.ReadLine() |> int

let main x =     
    let sqr = x * x
    (sqr + x) * (sqr + 1) + 1

[<EntryPoint>]
let entry args =
    printfn "%d" (main x)
    0
