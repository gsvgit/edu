module Task22

open Task15

let rec filter (less: MyList<int>) (more: MyList<int>) tail head =
    match tail with
    | Empty -> (less, more)
    | Cons(subhead, subtail) ->
        if subhead <= head
        then filter (Cons(subhead, less)) more subtail head
        else filter less (Cons(subhead, more)) subtail head

let rec union less more =
    match less with
    | Cons(a, subtail) -> Cons(a, (union subtail more))
    | Empty -> more
                

let rec main list = 
    match list with
    | Empty -> list
    | Cons(head, tail) ->
        let (less, more) = filter Empty Empty tail head
        union (main less) (Cons(head, (main more)))