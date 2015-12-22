module Task29

let main number=
    let mutable nm = number
    let mutable bit = ""

    if nm < 0L
    then
        nm <- nm &&&  System.Int64.MaxValue

    for i in 0..62 do
        bit <- ((nm % 2L) |> string) + bit
        nm <- (nm - nm % 2L)/2L

    if number < 0L
    then bit <- "1" + bit
    else bit <- "0" + bit

    bit

[<EntryPoint>]
let inter argv =
    printf "%s" (main (System.Console.ReadLine() |> int64))
    let rk = System.Console.ReadKey(true)
    0