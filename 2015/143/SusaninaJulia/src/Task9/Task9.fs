module Task9

let n = System.Console.ReadLine() |> int

let main n = 
    let fibN n = 
        let mutable a = 1
        let mutable b = 1
        for i in 3..n do
            a <- a + b
            b <- a - b
        a
    fibN n

[<EntryPoint>]
let entry args =
    printfn "%d" (main n)
    0