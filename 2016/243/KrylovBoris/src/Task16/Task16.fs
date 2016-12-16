module Task16

open Task15

let main MyList =
    let rec len lst counter = 
        match lst with
        | Cons(hd, tl) -> len tl (counter + 1)
        | Empty -> counter
    len MyList 0
