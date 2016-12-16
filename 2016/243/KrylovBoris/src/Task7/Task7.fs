module Task7

let main (inArray: array<int>) i j : array<int> =
    if i >= 0 || i < inArray.Length && j >= 0 || j < inArray.Length
    then
        inArray.[i] <- inArray.[i] ^^^ inArray.[j]
        inArray.[j] <- inArray.[i] ^^^ inArray.[j]
        inArray.[i] <- inArray.[i] ^^^ inArray.[j]
        let outArray = inArray
        outArray
    else
        failwith "Invalid indexes"
