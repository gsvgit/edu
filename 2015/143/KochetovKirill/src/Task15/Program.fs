module Task15

type List<'Typex> =
    |Empty
    |Cons of 'Typex * List<'Typex>

    member this.add(el: 'Typex) = 
        Cons(el, this)

    member this.out() = 
        let rec outer lst = 
            match lst with
            |Cons(hd, tl) -> 
                printfn "%A" <| hd 
                outer tl
            |Empty -> printfn "%A"
        outer this