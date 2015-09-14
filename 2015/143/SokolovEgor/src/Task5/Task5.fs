module Task5

let f_main (inArray:array<int>) lowBound highBound = 
    for i in 0..inArray.Length-1 do 
        if ((inArray.[i] > highBound) || (inArray.[i] < lowBound)) then inArray.[i] <- i else inArray.[i] <- -1
    inArray

let main (inArray:array<int>) lowBound highBound = 
    Array.filter (fun x -> x <> -1) (f_main inArray lowBound highBound)

