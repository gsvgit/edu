module Task5  

let main (inArray : array<int>) (lowBound : int) (highBound : int) = 
    let mutable lst = []
    for i in 0..inArray.Length - 1 do
        if (inArray.[i] < lowBound) || (inArray.[i] > highBound) 
        then lst <- i :: lst
    let indLst = lst
    let outArray = [|for i in List.rev(indLst) -> i|] 
    outArray