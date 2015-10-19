module Task3

let x = System.Console.ReadLine() |> int

let sqr x = x * x

let main x = (sqr x + x) * (sqr x + 1) + 1

[<EntryPoint>]
let entry args =
    printfn "%d" (main x)
    0
