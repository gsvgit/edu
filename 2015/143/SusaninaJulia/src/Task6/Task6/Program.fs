module Task6

let main (inArray:array<int>) = 
    inArray.[0] <- inArray.[0] + inArray.[1] 
    inArray.[1] <- inArray.[0] - inArray.[1]
    inArray.[0] <- inArray.[0] - inArray.[1]
   
    printfn "%A" inArray
    inArray