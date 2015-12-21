module Task22

open Task15

let rec filt lst cond = 
    match lst with
    | Empty -> lst
    | Cons(hd, tl) -> 
        if cond(hd)
        then Cons(hd, (filt tl cond))
        else filt tl cond 

let main (lst : MyList<int>) =
    let rec qsort (list : MyList<int>)  =
        match list with 
        | Empty -> list
        | Cons (hd, tl) ->
            (qsort (filt tl (fun x -> x < hd))).append(Cons(hd, (qsort (filt tl (fun x -> x >= hd)))))
    qsort lst