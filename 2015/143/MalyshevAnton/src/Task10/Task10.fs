module Task10

let rec fib fib_n1 fib_n2 n s = //fib_n1 = fib(n - 1) ; fib_n2 = fib(n - 2)
    if s = n
    then 
        fib_n1
    else 
        fib (fib_n1 + fib_n2) fib_n1 n (s + 1)
let main n =
    if n < 2
    then 
        n 
    else
        fib 1 0 n 1