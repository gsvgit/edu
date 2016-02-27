module Task15

type MyList<'t> =
    | Empty
    | Cons of 't * MyList<'t>
 
    member this.head() =
         match this with
         | Cons(vl, lst) -> vl

    member this.tail() =
        match this with
        | Cons(vl, lst) -> lst
        | Empty -> Empty  

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
    
    member this.addIn(el : 't) = 
        Cons(el, this)

    member this.length() =
        let rec lng list s =
            match list with
            | Empty -> s
            | Cons(vl, tl) -> lng tl (s + 1)
        lng this 0
     
     

 