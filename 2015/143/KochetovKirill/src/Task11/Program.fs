module Task11

  let mult (A:int[,]) (B:int[,]) = 
    let s00 = A.[0,0] * B.[0,0] + A.[0,1] * B.[1,0]
    let s01 = A.[0,0] * B.[0,1] + A.[0,1] * B.[1,1]
    let s10 = A.[1,0] * B.[0,0] + A.[1,1] * B.[1,0]
    let s11 = A.[1,0] * B.[0,1] + A.[1,1] * B.[1,1]
    let C = array2D  [ [ s00; s01 ]; [ s10; s11 ] ]
    C
  
  let rec mpower (Arr:int[,]) (n:int) =
    if n = 1 || n = 0 then
      Arr
    else
      let ret = mult Arr (mpower Arr (n - 1) )
      ret

  let main n =
    let mtrx = array2D [ [ 1; 1 ]; [ 1; 0 ] ]
    let ret = mpower mtrx (n - 1)
    ret.[0,0]

  let s = System.Console.ReadLine() |> int

  [<EntryPoint>]
  let inter argv = 
    printfn "%A" <| main s
    let rk = System.Console.ReadKey(true)
    0