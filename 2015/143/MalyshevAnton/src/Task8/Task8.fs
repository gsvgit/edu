module Task8

let rec main n =
    if n < 2 
    then 
        n 
    else 
        main (n - 1) + main (n - 2)