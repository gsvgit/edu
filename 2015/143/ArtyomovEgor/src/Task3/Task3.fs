module Task3

let input = System.Console.ReadLine() |> int
let square x = x * x
let main input = ((square input) + input) * ((square input) + 1) + 1
printfn "%A" (main input)