module Task4

let f_main (inArray:array<int>) (num:int) = 
    for i in 0..inArray.Length-1 do 
        if inArray.[i] <= num then inArray.[i] <- i else inArray.[i] <- -1
    inArray

let main (inArray:array<int>) (num:int) = 
    Array.filter (fun x -> x <> -1) (f_main inArray num)

