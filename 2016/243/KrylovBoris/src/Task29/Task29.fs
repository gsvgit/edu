module Task29

let main fp =
    let mutable buffStr = ""
    let f = System.Int64.MaxValue
    let mutable buff = fp
        
    if fp < 0L
    then 
        buff <- buff &&& f
    for i in 0 .. 62 do
        buffStr <- (buff >>> i &&& 1L |> string) + buffStr
    if fp < 0L
    then
        buffStr <- "1" + buffStr
    else
        buffStr <- "0" + buffStr

    buffStr

[<EntryPoint>]
let printer argv = 
    let t = main(System.Console.ReadLine() |> int64)
    printfn "%s" t
    System.Console.ReadKey()|> ignore
    0 
