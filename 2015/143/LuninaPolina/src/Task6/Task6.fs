module Task6

let main (inArray:int array) = 
    inArray.[0] <- inArray.[0] + inArray.[1]
    inArray.[1] <- inArray.[0] - inArray.[1]
    inArray.[0] <- inArray.[0] - inArray.[1]
    inArray