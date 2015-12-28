module Task3

let input = System.Console.ReadLine() |> int

let main input =
    let square = input * input
    (square + input) * (square + 1) + 1