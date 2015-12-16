module Task15

type MyList<'Typex> =
    | Empty
    | Cons of 'Typex * MyList<'Typex>

    member this.add(el : 'Typex) = 
        Cons(el, this)

    member this.addListToTheEnd(List : MyList<'Typex>) =
        let rec adder this =
            match this with
            | Empty -> List
            | Cons(vl, tl) -> Cons(vl, adder tl)
        adder this

    member this.out() = 
        let rec outer lst = 
            match lst with
            | Cons(hd, tl) -> 
                printfn "%A" <| hd 
                outer tl
            | Empty -> printfn "%A"
        outer this

    member this.head() = 
        match this with
        | Cons(vl, lst) -> vl

    member this.tail() =
        match this with
        | Cons(vl, lst) -> lst
        | Empty -> Empty

    member this.nextSwap() =
        match this with
        | Cons(vl, tl) ->
            match tl with
            | Cons(nextVl, nextTl) -> Cons(nextVl, Cons(vl, nextTl))

    member this.length() =
        let rec lng list s =
            match list with
            | Empty -> s
            | Cons(vl, tl) -> lng tl (s + 1)
        lng this 0
    
    member this.filter(is) =
        let rec flt lst =
            match lst with
            | Empty ->
                lst
            | Cons(vl, tl) ->
                if is(vl)
                then Cons(vl, flt tl)
                else flt tl
        flt this
    