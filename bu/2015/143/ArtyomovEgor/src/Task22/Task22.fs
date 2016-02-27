module Task22

open Task15

let main inLst: MyList<int> =
    let rec quicksort lst: MyList<int> =
        match lst with
        | Empty -> lst
        | Cons (hd, tl) ->
            (quicksort (lst.filter(fun x -> x < hd))).addEnd(Cons(hd, (tl.filter(fun x -> x = hd)))).addEnd(quicksort (tl.filter(fun x -> x > hd)))
    quicksort inLst