module Task15

type MyList<'t> =
    | Empty
    | Cons of 't * MyList<'t>
 
    member this.filter(is) =
        let rec fil lst =
            match lst with
            | Empty -> lst
            | Cons(vl, tl) ->
                if is(vl)
                then Cons(vl, fil tl)
                else fil tl
        fil this
    
    member this.add list =
        let rec addThis this =
            match this with
            | Empty -> list
            | Cons(head, tail) -> Cons(head, addThis tail)
        addThis this