module Task15

type MyList<'t> = 
    | Empty
    | Cons of 't * MyList<'t>

    member this.getHead() =
        match this with
        | Empty -> failwith  "Empty!"
        | Cons (hd, tl) -> hd

    member this.add(x) = 
        match this with
        | Empty -> Cons(x, Empty)
        | Cons(hd, tl) -> Cons(x, Cons(hd, tl))

    member this.addToTheEnd(x) =
        let rec add this x =
            match this with
            | Empty -> Cons (x, Empty)
            | Cons(hd, tl) -> Cons(hd, add tl x)
        add this x

    member this.deleteHead() =
        match this with
        | Empty -> Empty
        | Cons(hd, tl) -> tl

    member this.getTail() =
        match this with
        | Empty -> failwith "Empty!"
        | Cons(hd, tl) -> tl

    member this.swap() = 
        match this with
        | Empty -> Empty
        | Cons(hd, tl) -> Cons(tl.getHead(), Cons(hd, tl.getTail()))

    member this.getLength() =
        let rec length this len =
            match this with
            | Empty -> len
            | Cons(hd, tl) -> length tl (len + 1)
        length this 0  

    member this.filter(cond) =
        let rec filt lst = 
            match lst with
            | Empty -> lst
            | Cons(hd, tl) -> 
                if cond(hd)
                then Cons(hd, filt tl)
                else filt tl
        filt this

    member this.append(x) = 
        let rec app this = 
            match this with 
            | Empty -> x
            | Cons (hd, tl) -> Cons(hd, app tl)                                 
        app this