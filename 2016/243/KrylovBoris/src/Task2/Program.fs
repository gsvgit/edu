module Task2
  
  let main x = x*x*x*x + x*x*x + x*x + x + 1

  [<EntryPoint>]
  let vTask2 argv = 
    let y = System.Console.ReadLine() |> int
    printfn "%A" (main y)
    #if DEBUG
    System.Console.ReadKey(true)|> ignore
    #endif
    0 

