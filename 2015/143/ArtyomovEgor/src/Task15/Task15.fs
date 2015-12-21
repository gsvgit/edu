module Task15

open System

type MyList<'t> =
    | Empty
    | Cons of 't * MyList<'t>

    member myLst.length() =
        let rec lng l lst =
            match lst with
            | Empty -> l
            | Cons (hd, tl) -> lng (l + 1) tl
        lng 0 myLst

    member myLst.getHead() = 
        match myLst with
        | Empty -> failwith "Error."
        | Cons(a, __) -> a

    member myLst.getTail() =
        match myLst with
        | Cons(hd, tl) -> tl
        | Empty -> Empty

    member myLst.filter(check) =
        let rec fltr lst =
            match lst with
            | Empty -> lst
            | Cons (hd, tl) ->
                if check (hd) 
                then Cons (hd, fltr tl) 
                else fltr tl

        fltr myLst

    member myLst.addEnd(appendix) =
        let rec add myLst = 
            match myLst with
            | Cons (hd, tl) -> Cons (hd, add tl)
            | Empty -> appendix
        
        add myLst

    member myLst.add(el) =
        Cons (el, myLst)