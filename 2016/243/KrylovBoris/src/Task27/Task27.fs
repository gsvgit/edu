module Task27

let main fp =
    let mutable buffStr = ""
    let f = System.Int64.MaxValue
    let mutable buffFP = System.BitConverter.DoubleToInt64Bits fp
        
    if fp < 0.0
    then 
        buffFP <- buffFP &&& f
    for i in 0 .. 62 do
        buffStr <- (buffFP >>> i &&& 1L |> string) + buffStr
    if fp < 0.0
    then
        buffStr <- "1" + buffStr
    else
        buffStr <- "0" + buffStr

    buffStr

[<EntryPoint>]
let printer argv = 
    let t = main(System.Console.ReadLine() |> float)
    printfn "%s" t
    System.Console.ReadKey()|> ignore
    0 
