module Task7

let main (inArray:int array) (i:int) (j:int):int array =
    if i = j then
        ()
    else
        inArray.[i] <- inArray.[i] ^^^ inArray.[j]
        inArray.[j] <- inArray.[i] ^^^ inArray.[j]
        inArray.[i] <- inArray.[i] ^^^ inArray.[j]

    inArray
