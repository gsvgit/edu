module Task5
  
  let main (inArray: int array) lowBound highBound = 
    let outArray = 
      [|for a in 0..inArray.Length - 1 do
          if(inArray.[a] < lowBound || inArray.[a] > highBound) 
            then
              yield a|]
    outArray

  //let f = printfn "%A" <| main [|0;1;2;3;4;5|] 2 4