module Task8

let rec fibN n =
    if n < 1 then 0
    elif n <= 2 then 1
    else fibN(n - 1) + fibN(n - 2)