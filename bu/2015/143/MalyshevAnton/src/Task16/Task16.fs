module Task16

open Task15

let rec main list =
    match list with 
    | Empty -> 0
    | Cons(head, tail) -> 1 + (main tail)