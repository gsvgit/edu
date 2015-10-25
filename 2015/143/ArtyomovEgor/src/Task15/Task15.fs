module Task15

type MyList<'t> =
    | Empty
    | Cons of 't * MyList<'t>

    member myLst.length() =
        let rec lng l lst =
            match lst with
            | Empty -> l
            | Cons (hd, tl) -> lng (l+1) tl
        lng 0 myLst

    member myLst.getHead() = 
        match myLst with
        | Cons(vl, lst) -> vl

    member myLst.getTail() =
        match myLst with
        | Cons(vl, lst) -> lst
        | Empty -> Empty