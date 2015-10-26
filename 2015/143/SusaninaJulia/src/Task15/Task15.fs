module Task15

type MyList<'t> = 
    | Empty
    | Cons of 't * MyList<'t>

    member this.getHead() =
        match this with
        | Empty -> 
            let a = None
            let tmp = Option.get(a)
            tmp
        | Cons (hd, tl) -> 
            let a = Some(hd)
            let tmp = Option.get(a)
            tmp

    member this.add(x) = 
        match this with
        | Empty -> Cons(x, Empty)
        | Cons(hd, tl) -> Cons(x, Cons(hd, tl))

    member this.addToTheEnd(x) =
        let rec add list x =
            match list with
            | Empty -> Cons (x, Empty)
            | Cons(hd, tl) -> Cons(hd, add tl x)
        add this x

    member this.deleteHead() =
        match this with
        | Empty -> Empty
        | Cons(hd, tl) -> tl

    member this.getTail() =
        match this with
        | Empty -> Empty
        | Cons(hd, tl) -> tl

    member this.swap() = 
        match this with
        | Empty -> Empty
        | Cons(hd, tl) -> Cons(tl.getHead(), Cons(hd, tl.getTail()))

    member this.getLength() =
        let rec length list len =
            match list with
            | Empty -> len
            | Cons(hd, tl) -> length tl (len + 1)
        length this 0   