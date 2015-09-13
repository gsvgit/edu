module Task4

let f_main (inArray:array<int>) (num:int) = 
    for i in 0..inArray.Length-1 do 
        if inArray.[i] <= num then inArray.[i] <- i else inArray.[i] <- (num+1)
    inArray

let main (inArray:array<int>) (num:int) = 
    Array.filter (fun x -> x <> (num+1)) (f_main inArray num)

