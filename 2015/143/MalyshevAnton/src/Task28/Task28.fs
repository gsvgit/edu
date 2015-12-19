module Task28

let number = System.Console.ReadLine()|> int

let main number =
    let mutable num = number
    let mutable bit = ""
    if num >= 0 
    then num <- num
    else
        num <- num &&&  System.Int32.MaxValue
    for i in 0..30 do
        bit <- ((num % 2) |> string) + bit
        num <- (num - num % 2)/2
    if number >= 0 then bit <- "0" + bit else bit <- "1" + bit
    bit

printf "%A" (main number)
let a = System.Console.ReadLine()