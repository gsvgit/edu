module Task3

let num = System.Console.ReadLine()

let x = int num

let sqr x = x*x

let main x = (sqr x + x) * (sqr x + 1) + 1

[<EntryPoint>]
let entry args =
    printfn "%d" (main x)
    0
