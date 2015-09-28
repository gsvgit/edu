module Task12
open Task11

  let rec Fib (Arr:int[,]) (n:int) =
    if n = 1 || n = 0 then
      Arr
    else
      if n % 2 = 0 then
        let ret = Task11.mult (Fib Arr (n / 2) ) (Fib Arr (n / 2) )
        ret
      else
        let rc = Task11.mult (Fib Arr ( (n - 1) / 2) ) (Fib Arr ( (n - 1) / 2) )
        let ret = Task11.mult Arr rc
        ret
 
  let main n = 
    let mtrx = array2D [ [ 1; 1 ] ; [ 1; 0 ] ]
    let fibn = Fib mtrx (n - 1)
    fibn.[0,0]


  let s = System.Console.ReadLine() |> int

  [<EntryPoint>]
  let inter argv = 
    printfn "%A" <| main s
    let rk = System.Console.ReadKey(true)
    0