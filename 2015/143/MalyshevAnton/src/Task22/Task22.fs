module Task22

open Task15

let rec filter (less: MyList<'a>) (more: MyList<'a>) tail head =
    match tail with
    | Empty -> (less, more)
    | Cons(subhead, subtail) ->
        if subhead <= head
        then filter (Cons(subhead, less)) more subtail head
        else filter less (Cons(subhead, more)) subtail head

let rec connect less more =
    match less with
    | Cons(a, subtail) -> Cons(a, (connect subtail more))
    | Empty -> more
                

let main list = 
    if list = Empty 
    then MyList<int>.Empty
    else
        let rec quicksort list =
            match list with
            | Empty -> list
            | Cons(a, Empty) -> Cons(a, Empty)
            | Cons(head, tail) ->
                let (less, more) = filter Empty Empty tail head
                connect (quicksort less) ((Cons(head, (quicksort more))))
        quicksort list