module Task7

let main (inArray:array<int>) (i:int) (j:int) =
    if inArray <> [||] then
        inArray.[j] <- inArray.[i] + inArray.[j]
        inArray.[i] <- inArray.[j] - inArray.[i]
        inArray.[j] <- inArray.[j] - inArray.[i]
    
    printfn "%A" inArray
    inArray