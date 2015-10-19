module Task7

let main (inArray:array<int>) i j = 
    inArray.[i] <- inArray.[i] + inArray.[j] 
    inArray.[j] <- inArray.[i] - inArray.[j]
    inArray.[i] <- inArray.[i] - inArray.[j]
    inArray
