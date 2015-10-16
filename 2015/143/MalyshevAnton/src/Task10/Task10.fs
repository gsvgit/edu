module Task10

let rec fib fibN1 fibN2 n s = 
    if s = n
    then 
        fibN1
    else 
        fib (fibN1 + fibN2) fibN1 n (s + 1)
         
let main n =
    if n < 2 
    then 
        n 
    else
        fib 1 0 n 1