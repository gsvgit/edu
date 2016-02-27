module Task2

let main x = x*x*x*x + x*x*x + x*x + x + 1
let reading = System.Console.ReadLine() |> int
printfn "%A" (main reading)