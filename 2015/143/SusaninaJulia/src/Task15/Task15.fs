module Task15

type MyList<'t> = 
    | Empty
    | Cons of 't * MyList<'t>

    member this.getHead() =
        match this with
        | Cons (hd, tl) -> hd

    member this.add(x) = 
        Cons (x, this)

    member this.deleteHead() =
        match this with
        | Cons (hd, tl) -> tl

    member this.getTail() =
        match this with
        | Cons (hd, tl) -> tl

    member this.swap() = 
        match this with
        | Cons (hd, tl) -> Cons (tl.getHead(), Cons (hd, tl.getTail()))

    member this.getLength() =
        let rec length list len=
            match list with
            | Empty -> len
            | Cons(hd, tl) -> length (tl) (len + 1)
        length this 0

    member this.addToTheEnd(x) =
        let rec add list x=
            match list with
            | Empty -> Cons (x, Empty)
            | Cons (hd, tl) -> Cons(hd, add tl x)
        add this x

    