module Task5
let main (inArray:int array)  lowBound highBound = 
    let (outArray:int array) = [|for i in 0..inArray.Length - 1 do if inArray.[i] < lowBound || inArray.[i] > highBound then yield i|]
    outArray