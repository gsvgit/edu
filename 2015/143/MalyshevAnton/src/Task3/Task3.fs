module Task3

let x = System.Console.ReadLine() |> int
let a = x*x
let b = a*a
let main x =
    if x = 0
    then 1
    else b + b/x + a + x + 1
System.Console.WriteLine(main x)