module Task10

let rec fib f1 f2 n c  = 
    if n = c 
    then f2 
    else fib f2 (f1 + f2)  n (c + 1)

let main n =
    if n < 2 
    then n
    else fib 0 1 n 1

