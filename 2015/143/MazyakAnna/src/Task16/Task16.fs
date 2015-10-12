module Task16

type List<'T> =
    | Empty
    | Cons of 'T*List<'T>

let rec main List =
    match List with
    |Empty -> 0
    |Cons(int,tl) -> 1 + main List

