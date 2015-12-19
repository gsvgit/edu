module Task21

open Task15
open Task16

let rec bubbleSort list =
    match list with
    | Empty -> MyList<int>.Empty
    | Cons(head, tail) ->
        match tail with
        | Empty -> list 
        | Cons(nextHead, nextTail) -> 
            if head > nextHead
            then 
                Cons(nextHead, Cons(head, bubbleSort nextTail))
            else 
                Cons(head, bubbleSort tail)

let main list =
    let length = Task16.main list
    let rec sort list num =
        if (num < length) 
        then sort (bubbleSort list) (num + 1)
        else list

    sort list 0