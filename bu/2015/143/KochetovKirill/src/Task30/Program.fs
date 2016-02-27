module Task30
open Task15

type Num =
    int * Task15.MyList<int>

let compare (a : Task15.MyList<int>) (b : Task15.MyList<int>) =
    if a.length() > b.length()
    then
        1
    else
        if a.length() = b.length()
        then
            let rec cmpr (a : Task15.MyList<int>) (b : Task15.MyList<int>) (how) =
                match a, b with
                | Empty, Empty -> how
                | Cons(a, atl), Cons(b, btl) ->
                    if a = b
                    then
                        cmpr atl btl how
                    else
                        if a > b
                        then
                            cmpr atl btl 1
                        else
                            cmpr atl btl -1
            cmpr a b 0
        else
            -1

let rec summer (a : Task15.MyList<int>) (b : Task15.MyList<int>) (ost : int) =
    match a with
    | Empty ->
        match b with
        | Empty ->
            if ost > 0
            then
                Cons(ost, Empty)
            else
                Empty
        | Cons(hb, tlb) ->
            if hb + ost > 9 
            then
                Cons((hb + ost) % 10, (summer Empty tlb 1))
            else
                Cons(hb + ost, (summer Empty tlb 0))
    | Cons(ha, tla) ->
        match b with
        | Empty ->
            if ha + ost > 9 
            then
                Cons((ha + ost) % 10, (summer tla Empty 1))
            else
                Cons(ha + ost, (summer tla Empty 0))
        | Cons(hb, tlb) ->
            if hb + ha + ost > 9 
            then
                Cons((hb + ha + ost) % 10, (summer tla tlb 1))
            else
                Cons(hb + ha + ost, (summer tla tlb 0))

let rec minuser (a : Task15.MyList<int>) (b : Task15.MyList<int>) (ost : bool) =
    match a with
    | Empty -> Empty
    | Cons(ha, tla) ->
        match b with
        | Empty ->
            if ost 
            then 
                if ha - 1 < 0
                then
                    Cons(ha + 9, (minuser tla Empty true))
                else
                    Cons(ha - 1, (minuser tla Empty false))
            else
                Cons(ha, (minuser tla Empty false))
        | Cons(hb, tlb) ->
            if ost
            then 
                if ha - hb - 1 < 0
                then
                    Cons(ha - hb + 9, (minuser tla tlb true))
                else
                    Cons(ha - hb - 1, (minuser tla tlb false))
            else
                if ha - hb < 0
                then
                    Cons(ha - hb + 10, (minuser tla tlb true))
                else
                    Cons(ha - hb, (minuser tla tlb false))

let rec iszero (a : Task15.MyList<int>) =
    match a with
    | Empty -> true
    | Cons(head, tail) ->
        if head = 0
        then
            iszero tail
        else
            false
        

let rec cut (a : Task15.MyList<int>) =
    match a with
    | Empty -> Empty
    | Cons(head, tail) ->
        if iszero tail
        then
           Cons(head, Empty)
        else
            Cons(head, cut tail)

let sum (a : Num) (b : Num) =
    match a with
    | (sa, ra) ->
        match b with
        | (sb, rb) ->
            if sa * sb < 0 
            then
                if sa < 0 
                then
                    let cm = compare ra rb
                    if cm = 0
                    then
                        (1,Cons(0, Empty))
                    else
                        if cm = 1
                        then
                            (-1, cut (minuser ra rb false))
                        else
                            (1, cut (minuser rb ra false))
                else
                    let cm = compare ra rb
                    if cm = 0
                    then
                        (1,Cons(0, Empty))
                    else
                        if cm = 1
                        then
                            (1, cut (minuser ra rb false))
                        else
                            (-1, cut (minuser rb ra false))
            else
                if sa < 0 
                then
                    (-1, summer ra rb 0)
                else
                    (1, summer ra rb 0)

//let strtotape (str : int) =
//    let tape = Empty
//    let rec stt (tp : Task15.MyList<int>) (str : string) i =
//        if i <= str.Length
//        then stt (tp.add(str.[str.Length - i])) str (i + 1)
//        else tp
//    stt tape str 1 
//
//let reader = 
//    let string = System.Console.ReadLine()
//    strtotape string

//[<EntryPoint>]
//let inter argv = 
//    let s1 = System.Console.Read
//    let nm1 : Num = (s1, reader)
//    let s2 = System.Console.Read
//    let nm2 : Num = (s2, reader)
//    printfn("%A") <| sum nm1 nm2
//    let rk = System.Console.ReadKey(true)
//    0