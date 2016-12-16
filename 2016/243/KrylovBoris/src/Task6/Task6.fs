module Task6

let main (inArray: array<int>) : array<int> =
    if inArray.Length > 0 then  
        inArray.[0] <- inArray.[0] ^^^ inArray.[1]
        inArray.[1] <- inArray.[0] ^^^ inArray.[1]
        inArray.[0] <- inArray.[0] ^^^ inArray.[1]
        let outArray = inArray
        outArray
    else
        failwith "Invalid array"