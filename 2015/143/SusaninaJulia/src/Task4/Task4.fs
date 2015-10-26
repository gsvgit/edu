module Task4

let main (inArray : array<int>) (num : int) = 
    let mutable lst = []
    for i in 0..inArray.Length - 1 do
        if num >= inArray.[i] 
        then lst <- i :: lst
    let indLst = lst
    let outArray = [|for i in List.rev(indLst) -> i|] 
    outArray
