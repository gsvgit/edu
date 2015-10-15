module Task6

let main (inArray:array<int>) =
    if inArray <> [||] 
    then
        inArray.[1] <- inArray.[0] + inArray.[1]
        inArray.[0] <- inArray.[1] - inArray.[0]
        inArray.[1] <- inArray.[1] - inArray.[0]
    
    printfn "%A" inArray
    inArray