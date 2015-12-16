module Task30
open Task15

type Num =
    int * Task15.MyList<int>

let rec compare (a : Task15.MyList<int>) (b : Task15.MyList<int>) (is : bool) =
    if a.length > b.length
    then
        true
    else
        if a.length = b.length
            
        else
            false

let rec summer (a : Task15.MyList<int>) (b : Task15.MyList<int>) (ost : int) =
    match a with
    | Empty ->
        match b with
        | Empty -> Empty
        | Cons(hb, tlb) ->
            if hb + ost > 9 
            then
                (summer Empty tlb 1).addListToTheEnd(Cons((hb + ost) % 10, Empty)
            else
                (summer Empty tlb 0).addListToTheEnd(Cons(hb + ost, Empty))
    | Cons(ha, tla) ->
        match b with
        | Empty ->
            if ha + ost > 9 
            then
                (summer tla Empty 1).addListToTheEnd(Cons((ha + ost) % 10, Empty)
            else
                (summer tla Empty 0).addListToTheEnd(Cons(ha + ost, Empty))
        | Cons(hb, tlb) ->
            if hb + ha + ost > 9 
            then
                (summer tla tlb 1).addListToTheEnd(Cons(hb + ha + ost) % 10, Empty)
            else
                (summer tla tlb 0).addListToTheEnd(Cons(hb + ha + ost, Empty))

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
                    (minuser tla Empty true).addListToTheEnd(Cons(ha + 9, Empty))
                else
                    (minuser tla Empty false).addListToTheEnd(Cons(ha - 1, Empty))
            else
                (minuser tla Empty false).addListToTheEnd(Cons(ha, Empty))
        | Cons(hb, tlb) ->
            if ost
            then 
                if ha - hb - 1 < 0
                then
                    (minuser tla tlb true).addListToTheEnd(Cons(ha - hb + 9, Empty))
                else
                    (minuser tla tlb false).addListToTheEnd(Cons(ha - hb - 1, Empty))
            else
                if ha - hb < 0
                then
                    (minuser tla tlb true).addListToTheEnd(Cons(ha - hb + 10, Empty))
                else
                    (minuser tla tlb false).addListToTheEnd(Cons(ha - hb, Empty))
                
let sum (a : Num) (b : Num) =
    match a with
    | (sa, ra) ->
        match b with
        | (sb, rb) ->
            if sa * sb < 0 
            then
                if sa < 0 
                then
                    
                else
                    if ra.length > rb.length
                    then
                       (-1, minuser ra rb false) 
                    else                        
                        if(ra.last >)
            else
                if sa < 0 
                then
                    (1, summer ra rb 0)
                else
                    (-1, summer ra rb 0)
