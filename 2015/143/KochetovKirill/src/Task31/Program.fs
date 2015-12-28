module Task31

open Task30
open Task15

let rec degger (t : MyList<int>) deg =
    if deg = 0
    then
        t
    else
        degger (t.add(0)) (deg - 1)

let rec smr (t : Task15.MyList<int>) (amount : int) = 
    if amount = 0
    then
        Cons(0, Empty)
    elif amount = 1
    then
        t
    elif amount % 2 = 0
    then
        smr (Task30.summer t t 0) (amount / 2)
    else
        Task30.summer (smr (Task30.summer t t 0) ((amount - 1) / 2)) t 0

let rec mlt (a : Task15.MyList<int>) (sum : Task15.MyList<int>) (b : Task15.MyList<int>) (deg : int) =
    match a with
    | Empty ->
        sum
    | Cons(head, tail) ->
        mlt 
        <| tail 
        <| (Task30.summer sum (smr (degger b deg) head) 0) 
        <| b 
        <| (deg + 1)
        
let mult (a : Task30.Num) (b : Task30.Num) =
    match a, b with
    | (sa, ra), (sb, rb) ->
        (sa*sb, mlt ra Empty rb 0)