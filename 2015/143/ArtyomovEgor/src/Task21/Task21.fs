module Task21

open Task15

let bubblesort (inList:MyList<int>) =
    let rec listMove lst =
        match lst with
        | Empty -> lst
        | Cons (hd, Empty) -> lst
        | Cons (hd, tl) ->
            if hd > tl.getHead()
            then Cons (tl.getHead(), listMove (Cons (hd, tl.getTail())))
            else Cons (hd, listMove tl)

    let rec sort lst i =
        if i < inList.length()
        then
            sort (listMove lst) (i + 1)
        else
            lst

    sort inList 0