module Task8

let input = System.Console.ReadLine() |> int

let rec fibN n =
    if n < 1 then 0
    elif n <= 2 then 1
    else fibN(n - 1) + fibN(n - 2)

printfn "%d" (fibN input)