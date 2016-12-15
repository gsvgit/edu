module Task15

type MyList<'t> =
    | Empty
    | Cons of 't * MyList<'t>

    member this.length() =
        let rec listLength lst op =
            match lst with
            |Empty -> op
            |Cons (hd, tl) -> listLength tl (op + 1)
        listLength this 0
    
    member this.head() =
        match this with
        |Empty -> failwith "Empty"
        |Cons (hd, tl) -> hd
    
    member this.tail() =
        match this with
        |Empty -> Empty
        |Cons (hd,tl) -> tl

    member this.add(x) =
        match this with
        |Empty -> Cons (x, Empty)
        |Cons (hd, tl) -> Cons(x, Cons(hd, tl))
    
    member this.exists (condition) =
        let rec exist lst flag =
            if not(flag)
            then
                match lst with
                |Empty -> false
                |Cons(hd, tl) -> 
                    if condition hd
                    then true
                    else exist tl flag
            else flag
        exist this false

    member this.swap() =
        match this with
        |Empty -> failwith "Empty"
        |Cons(hd, tl) -> 
            match tl with
            |Empty -> Cons(hd, Empty)
            |Cons(hd1, tl1) -> Cons(hd1, Cons(hd, tl1))
        
    
    member this.filter(condition) =
        let rec filt res =
            match res with
            |Empty -> res
            |Cons (hd, tl) -> 
                if condition hd
                then Cons(hd, filt tl)
                else filt tl
        filt this

