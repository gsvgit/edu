module Task5

  let main (inArray: int array) lowBound highBound = 
      let mutable i = 0
      let outArray:int array = 
        [|for i in 0..inArray.Length-1 do
            if ((inArray.[i] > highBound) || (inArray.[i] < lowBound)) then yield i|]
      outArray
