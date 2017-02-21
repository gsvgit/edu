module Task22
open Task15

let main inList: MyList<int> =
    let concatenate list1 list2 =
        let rec add lst =
            match lst with
            |Empty -> list2
            |Cons(hd, tl) -> Cons(hd, add tl)
        add list1

                
    let rec qsort lst: MyList<int> =
        match lst with
        |Empty -> Empty
        |Cons(hd, Empty) -> lst
        |Cons(hd, tl) ->
            concatenate (qsort(tl.filter((>) hd))) (Cons(hd, qsort(tl.filter((<=) hd))))
    qsort inList