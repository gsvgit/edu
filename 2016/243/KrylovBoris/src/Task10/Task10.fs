module Task10

let rec calc curr k m n = 
    if not (curr = n)
    then calc (curr + 1) (m + k) k n
    else k + m


let main n =
    if (n = 0) || (n = 1) 
    then 1
    elif n > 1 then calc 2 1 1 n
    else failwith "Invalid number"