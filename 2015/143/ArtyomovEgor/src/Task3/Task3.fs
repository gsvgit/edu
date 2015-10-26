module Task3

let x = System.Console.ReadLine() |> int
let sqx = x * x
let main input = (sqx + x) * (sqx + 1) + 1
printfn "%A" (main x)