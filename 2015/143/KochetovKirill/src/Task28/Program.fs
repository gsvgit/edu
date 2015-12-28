module Task28

let main number =
    let mutable nm = number
    let mutable bit = ""

    if nm < 0 
    then 
        nm <- nm &&&  System.Int32.MaxValue

    for i in 0..30 do
        bit <- (((nm >>> i) &&& 1) |> string) + bit

    if number < 0
    then bit <- "1" + bit
    else bit <- "0" + bit

    bit

[<EntryPoint>]
let inter argv =
    printf "%s" <| (main (System.Console.ReadLine() |> int))
    let rk = System.Console.ReadKey(true)
    0