module Task16

open Task15

let main lst =
    let rec len lst s =
        match lst with
        | Empty -> s
        | Cons (hd, tl) -> len tl (s + 1)
    len lst 0