module Task16

type int_List = 
    |Empty
    |Cons of int*int_List

let main list =
    let rec sumEl lst s =
        match lst with
        |Empty -> s
        |Cons (hd, tl) -> sumEl tl (s+1)
    sumEl list 0
