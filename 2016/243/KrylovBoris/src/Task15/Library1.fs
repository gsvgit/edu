module Task15

type List<'t> =
    | Empty
    | Cons of 't * List<'t>

    member this.length() =
        let rec listLength lst op =
            match this with
            |Empty -> Empty
            |Cons (hd,tl) -> listLength lst (op+1)
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
        let mutable flag = false
        let rec exist lst =
            if (flag) then flag
            else   
                match lst with
                |Empty -> false
                |Cons(hd, tl) -> 
                    if condition(hd)
                    then flag = true
                    else exist(tl)
        exist this |> ignore
        flag

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
                if condition(hd)
                then Cons(hd, filt tl)
                else filt tl
        filt this

