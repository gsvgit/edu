module Task16

type List<'t> = 
    |Empty
    |Cons of 't*List<'t>

let main list =
    let rec sumEl lst s =
        match lst with
        |Empty -> s
        |Cons (hd, tl) -> sumEl tl (s+1)
    sumEl list 0
