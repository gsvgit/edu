module Task8

let rec fib n = match n with
| 0 -> 0
| 1 | 2 -> 1
| _ -> if n > 1 then fib (n - 1) + fib (n - 2)
       else fib (n + 2) - fib (n + 1)

let main n = fib n
