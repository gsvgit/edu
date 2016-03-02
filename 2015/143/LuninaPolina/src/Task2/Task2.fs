module Task2

let main x = x * x * x * x + x * x * x + x * x + x + 1
let input = System.Console.ReadLine() |> int
System.Console.WriteLine(main input)