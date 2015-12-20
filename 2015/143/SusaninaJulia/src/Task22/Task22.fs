module Task22

open Task15

let main (lst : MyList<int>) =
    let rec qsort (list : MyList<int>)  =
        match list with
        | Empty -> list
        | Cons (hd, tl) ->
            let less = list.filter(fun x -> x < hd)
            let more = list.filter(fun x -> x > hd)
            (qsort less).append(Cons(hd, qsort more))
    qsort lst

