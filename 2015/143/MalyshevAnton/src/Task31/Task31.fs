module Task31

open Task15

type Num = int * MyList<int>

let rec reverse (list: MyList<int>) =
    let rec last list =
        match list with
        | Cons(head, Empty) -> head
        | Cons(head, tail) -> last tail
        | Empty -> 0
    let rec cut list =
        match list with 
        | Cons(head, Empty) -> Empty
        | Cons(head, tail) -> Cons (head, cut tail)
        | Empty -> Empty
    match list with
    | Empty -> Empty
    | Cons(head, tail) -> Cons(last list, reverse (cut list))

let rec cutzero list =
    match list with
    | Cons(0, Empty) -> Cons(0, Empty)
    | Empty -> Empty
    | Cons(head, tail) ->
        if head = 0
        then cutzero tail
        else Cons(head, tail)  

let rec sum numlist1 numlist2 remain =
    match numlist1, numlist2 with
    | Cons(ahead, atail), Cons(bhead, btail) ->
        let head = (ahead + bhead + remain) % 10
        let newremain = (ahead + bhead + remain) / 10
        Cons(head, (sum atail btail newremain))

    | Cons(ahead, atail), Empty ->
        let head = (ahead + remain) % 10
        let newremain = (ahead + remain) / 10
        Cons(head, (sum atail Empty newremain))
        
    | Empty, Cons(bhead, btail) ->
        let head = (bhead + remain) % 10
        let newremain = (bhead + remain) / 10
        Cons(head, (sum Empty btail newremain))

    | Empty, Empty -> if remain > 0 then Cons(remain, Empty) else Empty

let rec addCons list count =
    if count > 0
    then addCons (Cons(0, list)) (count - 1)
    else list

let rec mult list num remain = 
    match list with
    | Empty -> if remain > 0 then Cons(remain, Empty) else Empty
    | Cons(a, tail) -> 
        if (a * num + remain) > 9
        then
            let head = (a * num + remain) % 10
            let newremain = (a * num + remain)/10
            Cons(head, (mult tail num newremain))
        else
            let head = a * num + remain
            Cons(head, (mult tail num 0))

let rec multiply alist blist count =
    match alist with
    | Empty -> Empty
    | Cons(a, tail) -> sum (addCons (mult blist a 0) count) (multiply tail blist (count + 1)) 0

let multiplication (anum: Num) (bnum: Num) =
    match anum, bnum with
    | (1, alist), (1, blist)
    | (-1, alist), (-1, blist) -> (1, (cutzero (reverse (multiply (reverse alist) (reverse blist) 0))))
    | (-1, alist), (1, blist)
    | (1, alist), (-1, blist) -> 
        if (cutzero (reverse (multiply (reverse alist) (reverse blist) 0))) = Cons(0, Empty)
        then (1, (cutzero (reverse (multiply (reverse alist) (reverse blist) 0))))
        else (-1, (cutzero (reverse (multiply (reverse alist) (reverse blist) 0))))