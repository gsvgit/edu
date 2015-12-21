module Task29

let number = System.Console.ReadLine()|> int64

let main number=
    let mutable num = number
    let mutable bit = ""

    if num >= 0L
    then num <- num
    else
        num <- num &&&  System.Int64.MaxValue

    for i in 0..62 do
        bit <- ((num % 2L) |> string) + bit
        num <- (num - num % 2L)/2L

    if number >= 0L then bit <- "0" + bit else bit <- "1" + bit
    bit

printf "%A" (main number)
//let a = System.Console.ReadLine()