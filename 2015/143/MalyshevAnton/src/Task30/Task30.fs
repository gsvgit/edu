module Task30

open Task15

type Num = int * MyList<int>

let rec length list =
    match list with 
    | Empty -> 0
    | Cons(head, tail) -> 1 + (length tail)

let rec reverse (list: MyList<int>) =
    let rec last list =
        match list with
        | Cons (hd, Empty) -> hd
        | Cons (hd, tl) -> last tl
        | Empty -> 0
    let rec cut lst =
        match lst with 
        | Cons (hd, Empty) -> Empty
        | Cons (hd, tl) -> Cons (hd, cut tl)
        | Empty -> Empty
    match list with
    | Empty -> Empty
    | Cons (hd, tl) -> Cons (last list, reverse (cut list))

let rec comparing alist blist =
    match alist, blist with
    | Cons(a, atail), Cons(b, btail) ->
        if a > b
        then "more"
        elif a < b
        then "less"
        else comparing atail btail
    | Empty, Empty -> "0"

let compare alist blist =
    if length alist > length blist
    then "more"
    elif length alist < length blist
    then "less"
    else comparing alist blist

let rec cutzero list =
    match list with
    | Empty -> Empty
    | Cons (hd, tail) ->
        if hd = 0
        then cutzero tail
        else Cons (hd, tail)  
 
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

let rec difference numlist1 numlist2 remain =
    match numlist1, numlist2 with
    | Cons(ahead, atail), Cons(bhead, btail) ->
        if ahead >= bhead + remain
        then 
            let head = ahead - bhead - remain
            let newremain = 0
            Cons(head, (difference atail btail newremain))
        else
            let newremain = 1
            let head = ahead + 10 - bhead - remain
            Cons(head, (difference atail btail newremain))

    | Cons(ahead, atail), Empty ->
        if ahead >= remain
        then
            let head = ahead - remain
            let newremain = 0
            Cons(head, (difference atail Empty newremain))
        else
            let newremain = 1
            let head = ahead + 10 - remain
            Cons(head, (difference atail Empty newremain))

    | Empty, Empty -> Empty

let main (num1: Num) (num2: Num) =
    match num1, num2 with
    | (-1, lista), (-1, listb) -> (-1, (reverse (sum (reverse lista) (reverse listb) 0)))
    | (1, lista), (1, listb) -> (1, (reverse (sum (reverse lista) (reverse listb) 0)))
    | (-1, lista), (1, listb) ->
        if compare lista listb = "more"
        then (-1, (cutzero (reverse (difference (reverse lista) (reverse listb) 0))))
        elif compare lista listb = "less"
        then (1, (cutzero (reverse (difference (reverse listb) (reverse lista) 0))))
        else (1, Cons(0, Empty))
    | (1, lista), (-1, listb) ->
        if compare lista listb = "more"
        then (1, (cutzero (reverse (difference (reverse lista) (reverse listb) 0))))
        elif compare lista listb = "less"
        then (-1, (cutzero (reverse (difference (reverse listb) (reverse lista) 0))))
        else (1, Cons(0, Empty))