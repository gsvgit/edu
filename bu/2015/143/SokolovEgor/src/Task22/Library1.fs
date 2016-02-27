module Task22
open Task15

let main list = 
    if list = Empty 
    then MyList<int>.Empty
    else
        let rec qsort list =
            match list with
            | Empty -> list
            | Cons(head, tail) -> 
                let small = tail.filter(fun x -> x <= head)
                let big = tail.filter(fun x -> x > head)
                (qsort small).add(Cons(head, qsort(big)))
        qsort list



