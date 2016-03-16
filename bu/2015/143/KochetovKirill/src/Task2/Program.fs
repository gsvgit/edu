module Task2
  
  let s = System.Console.ReadLine() |> int
  let main x = x*x*x*x + x*x*x + x*x + x + 1

  [<EntryPoint>]
  let inter argv = 
    printfn "%A" <| main s
    //let rk = System.Console.ReadKey(true)
    0