module Task4

let main (inArray:array<int>) (num:int) =
    let mutable answer = List.Empty

    for i in 0..inArray.Length - 1 do
        if num >= inArray.[i] then
            answer <- i :: answer

    let immut = answer
    let outArray = [|for i in List.rev(immut) -> i|]

    printfn "%A" outArray
    outArray