module Task10

  let main n = 
    let next c d =
      for a in 3..n do
        c = c + d
        d = c - d
    next 1 1

  let n = System.Console.ReadLine() |> int

  [<EntryPoint>]
  let inter argv = 
    printfn "%A" <| main n
    let rk = System.Console.ReadKey(true)
    0
    