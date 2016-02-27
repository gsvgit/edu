module Task2

let main x = x*x*x*x + x*x*x + x*x + x + 1
let r = System.Console.ReadLine() |> int
System.Console.WriteLine(main r)