module Task10

  let rec next a b i n = 
    if i = n then
      a
    else
      next (a + b) a (i + 1) n

  let main n =
    if n = 1 then
      1
    else 
      next 1 1 2 n
  
//  let n = System.Console.ReadLine() |> int
//
//  [<EntryPoint>]
//  let inter argv = 
//    printfn "%A" <| main n
//    let rk = System.Console.ReadKey(true)
//    0
    