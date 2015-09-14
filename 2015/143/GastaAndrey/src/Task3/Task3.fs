module Task3

let f_step x = x*x*x*x

let main x = 
    if x = 0 then 1
    else (f_step x) + ((f_step x) / x) + (((f_step x) / x) / x) + x + 1
let reading = System.Console.ReadLine() |> int
printfn "%A" (main reading)