module Task16

type List<'a> =
    |Empty
    |Cons of 'a * List<'a>

let rec main list =
    match list with 
    |Empty -> 0
    |Cons(head, tail) -> 1 + (main tail)