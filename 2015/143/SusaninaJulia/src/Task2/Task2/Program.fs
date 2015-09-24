module Task2

let num = System.Console.ReadLine()

let x = int num

let main x = x*x*x*x + x*x*x + x*x + x + 1

[<EntryPoint>]
let entry args =
    printfn "%d" (main x)
    0
