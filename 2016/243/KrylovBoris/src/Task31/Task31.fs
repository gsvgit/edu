module Task31

open Task15
open Task30

let rec shift (lst: MyList<int>) index =
    if index = 0 
    then 
        lst
    else 
        shift (Cons(0, lst)) (index - 1)

let rec multByNumber (lst: MyList<int>) index =
    if index = 0 
    then 
        Cons(0, Empty)
    elif index = 1
    then 
        lst
    elif index % 2 = 0
    then
        multByNumber (addition lst lst 1 1 0) (index / 2)
    else
        addition (multByNumber (addition lst lst 1 1 0) (index / 2)) lst 1 1 0

let rec multiplyRec (a: MyList<int>) (buff: MyList<int>) (b: MyList<int>) (ind: int) =
    match a with
    |Empty -> buff
    |Cons(hd, tl) -> multiplyRec tl (addition buff (multByNumber (shift b ind) hd) 1 1 0) b (ind + 1)

let multiply (a: Num) (b: Num) =
    match a, b with
    |(signA, lstA), (signB, lstB) ->
        signA * signB, multiplyRec lstA Empty lstB 0
