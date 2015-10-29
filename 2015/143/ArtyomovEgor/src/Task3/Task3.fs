module Task3

let x = System.Console.ReadLine() |> int

let main x = 
    let sqx = x * x
    (sqx + x) * (sqx + 1) + 1

printfn "%A" (main x)