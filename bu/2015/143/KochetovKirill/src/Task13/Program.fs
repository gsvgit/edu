module Task13

  let main n = 
    let Fib = Array.create n 1
    for i in 2..(n - 1) do
      Fib.[i] <- Fib.[i - 1] + Fib.[i - 2]
    Fib

//  let s = System.Console.ReadLine() |> int
//
//  [<EntryPoint>]
//  let inter argv = 
//    printfn "%A" <| main s
//    let rk = System.Console.ReadKey(true)
//    0