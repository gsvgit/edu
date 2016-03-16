module Task7

let main (inArray:int array) i j = 
    inArray.[i] <- inArray.[i] + inArray.[j]
    inArray.[j] <- inArray.[i] - inArray.[j]
    inArray.[i] <- inArray.[i] - inArray.[j]
    let outArray = inArray
    outArray