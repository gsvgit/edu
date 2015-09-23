module Task12
  
  let mult (A:int[,]) (B:int[,]) = 
    let s00 = A.[0,0] * B.[0,0] + A.[0,1] * B.[1,0]
    let s01 = A.[0,0] * B.[0,1] + A.[0,1] * B.[1,1]
    let s10 = A.[1,0] * B.[0,0] + A.[1,1] * B.[1,0]
    let s11 = A.[1,0] * B.[0,1] + A.[1,1] * B.[1,1]
    let C = array2D  [ [ s00; s01 ]; [ s10; s11 ] ]
    C

  let rec Fib (Arr:int[,]) (n:int) =
    if n = 1 || n = 0 then
      Arr
    else
      if n % 2 = 0 then
        let ret = mult (Fib Arr (n / 2) ) (Fib Arr (n / 2) )
        ret
      else
        let rc = mult (Fib Arr ( (n - 1) / 2) ) (Fib Arr ( (n - 1) / 2) )
        let ret = mult Arr rc
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