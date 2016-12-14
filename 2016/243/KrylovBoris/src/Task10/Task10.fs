module Task10

let rec calc curr k m n = 
    if not(curr = n)
    then calc (curr + 1) (m + k) k n
    else k


let main n =
    if n = 0 
    then
        0
    elif (n = 1) || (n = 2) 
    then
        1
    else
        calc 2 1 1 n