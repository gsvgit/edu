module Task10

let input = System.Console.ReadLine() |> int

let rec fibN n =
    let mas = [|1; 1; 2; 3|]
    if n > 0
    then
        if n <= 4 then mas.[n-1]
        else fibN(n - 1) + fibN(n - 2)
    else 0

printfn "%d" (fibN input)