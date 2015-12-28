module Task5

let main (inArray:array<int>) (lowBound:int) (highBound:int) =
    let mutable answer = List.Empty

    if lowBound <= highBound 
    then 
        for i in 0..inArray.Length - 1 do
            if (highBound < inArray.[i]) || (lowBound > inArray.[i]) 
            then answer <- i :: answer
    else for i in 0..inArray.Length - 1 do
            if (highBound > inArray.[i]) || (lowBound < inArray.[i]) 
            then answer <- i :: answer

    let immut = answer
    let outArray: int array = [| for i in List.rev(immut) -> i |]
    outArray