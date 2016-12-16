module Task28

let main fp =
    let mutable buffStr = ""
    let f = System.Int32.MaxValue
    let mutable buff = fp

    if fp < 0
    then 
        buff <- buff &&& f

    for i in 0 .. 30 do
        buffStr <- (buff >>> i &&& 1 |> string) + buffStr
    if fp < 0
    then
        buffStr <- "1" + buffStr
    else
        buffStr <- "0" + buffStr

    buffStr

[<EntryPoint>]
let printer argv = 
    let t = main(System.Console.ReadLine() |> int)
    printfn "%s" t
    System.Console.ReadKey()|> ignore
    0 
