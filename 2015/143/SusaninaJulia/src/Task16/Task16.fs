module Task16
open Task15

let main myList = 
    let rec length list len=
        match list with
        | Empty -> len
        | Cons(hd, tl) -> length (tl) (len + 1)
    length myList 0
