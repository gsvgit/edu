module Task16

open Task15

  let main List =
    let rec len lst counter = 
        match lst with
        | Cons(hd, tl) -> len tl (counter + 1)
        | Empty -> counter
    len List 0
