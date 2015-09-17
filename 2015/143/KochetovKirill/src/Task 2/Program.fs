module Task2
  
  let s = System.Console.ReadLine() |> int
  let main x =
    let p = x*x*x*x + x*x*x + x*x + x
    p

  [<EntryPoint>]
  let inter argv = 
    printfn "%A" <| main s
    //let rk = System.Console.ReadKey(true)
    0