module Task10


let rec fib first second n i = 
    if (i = n) then
        first
    else 
        fib (first + second) first n (i+1)


let main n = 
    if (n = 1 || n = 2) then 1
    else fib 1 1 n 2


            