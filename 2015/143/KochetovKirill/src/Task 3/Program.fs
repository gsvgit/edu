module Task3

  let s = System.Console.ReadLine() |> int
  let main x =
    let x2 = x * x
    (x2 + x)*(x2 + 1)
  
  [<EntryPoint>]
  let inter argv = 
    printfn "%A" <| main s
    //let rk = System.Console.ReadKey(true)
    0
