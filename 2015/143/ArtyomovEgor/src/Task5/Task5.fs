﻿module Task5

let main (inArray:array<int>) (lowBound:int) (highBound:int) =
    let mutable answer = List.Empty

    for i in 0..inArray.Length - 1 do
        if (highBound < inArray.[i]) || (lowBound > inArray.[i]) then
            answer <- i :: answer

    let immut = answer
    let outArray = [|for i in List.rev(immut) -> i|]

    printfn "%A" outArray
    outArray