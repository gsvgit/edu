module Task6

let main (inArray: int array) = 
    //let a = inArray.[0]
    //let b = inArray.[1]
    //a <- a - b
    //b <- a + b
    //a <- b - a
    inArray.[0] <- inArray.[0] - inArray.[1]
    inArray.[1] <- inArray.[0] + inArray.[1]
    inArray.[0] <- inArray.[1] - inArray.[0]
    let outArray = inArray
    outArray