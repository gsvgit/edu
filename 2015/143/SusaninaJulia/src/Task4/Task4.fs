module Task4

let main (inArray:array<int>) (num:int) = 
 
    let mutable L = []

    for i in 0..inArray.Length - 1 do
        if num >= inArray.[i] then 
            L <- i :: L
    let indL = L
    let outArray = [|for i in List.rev(indL) -> i|] 
    outArray
