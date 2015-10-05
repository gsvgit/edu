let fibN n =
    let mutable a = 1
    let mutable b = 1
    // if n < 1 then 0
    //elif n <= 2 then 1
    //else 
    for i in 1..n-1 do
        a <- a + b          //a1=2 b1=1  
        b <- a - b          //a2=2 b2=1
    b                       //a3=3 b3=2
                            //a4=5 b4=3