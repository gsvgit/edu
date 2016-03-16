module Task4

let main (inArray : int array) num = 
    let (outArray : int array) = [|for i in 0..inArray.Length - 1 do if inArray.[i] <= num then yield i|]
    outArray
