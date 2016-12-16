module Task3
  let main x = 
    let x2 = x * x
    x2 * x2 + x2 * x + x2 + x + 1

  [<EntryPoint>]
  let vTask3 argv = 
    let y = System.Console.ReadLine() |> int
    printfn "%A" (main y)
    System.Console.ReadKey(true)|> ignore
    0