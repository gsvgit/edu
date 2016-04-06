module Task9
  
  let main n =
    let mutable c = 1
    let mutable b = 1
    for a in 3..n do
      c <- c + b
      b <- c - b
    c
  
//  let n = System.Console.ReadLine() |> int
//
//  [<EntryPoint>]
//  let inter argv = 
//    printfn "%A" <| main n
//    let rk = System.Console.ReadKey(true)
//    0
      