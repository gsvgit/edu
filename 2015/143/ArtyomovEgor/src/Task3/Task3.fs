let input = System.Console.ReadLine() |> int
let square x = x * x
let main = (square input + input) * (square input + 1) + 1
printfn "%A" (main input)