module Task2

let x = System.Console.ReadLine() |> int

let main x = x*x*x*x + x*x*x + x*x + x + 1

[<EntryPoint>]
let entry args =
    printfn "%d" (main x)
    0
