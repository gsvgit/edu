module Task16

open Task15

let main list =
    let rec sumEl lst s =
        match lst with
        | Empty -> s
        | Cons (hd, tl) -> sumEl tl (s + 1)
    sumEl list 0