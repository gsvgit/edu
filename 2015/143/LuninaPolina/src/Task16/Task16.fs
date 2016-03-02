module Task16
open Task15

let main (list:List<'T>) = 
    let rec length list l =
        match list with
        | Empty -> l
        | Cons(a,b) -> length b (l + 1)  
    length list 0