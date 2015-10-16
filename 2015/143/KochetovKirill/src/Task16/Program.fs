module Task16
open Task15

let main MyList =
    let rec len lst s = 
        match lst with
        | Cons(hd, tl) -> len tl (s + 1)
        | Empty -> s
    len MyList 0