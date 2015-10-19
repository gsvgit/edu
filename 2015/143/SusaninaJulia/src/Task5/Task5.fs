module Task5  

let main (inArray:array<int>) (lowBound:int) (highBound:int) = 

    let mutable L = []

    for i in 0..inArray.Length - 1 do
        if (inArray.[i] < lowBound) || (inArray.[i] > highBound) then 
            L <- i :: L
    let indL = L
    let outArray = [|for i in List.rev(indL) -> i|] 
    outArray
