module Task4

  //let Arr = [|1;2;3;4|]
  //let n = 0

  let main (inArray: int array) num = 
    let mutable k = 0
    let outArray:int array = 
      [|for a in 0..inArray.Length - 1 do 
          if inArray.[a] <= num 
            then 
              yield a|]
    outArray

  //let f = printfn "%A" <| main Arr n