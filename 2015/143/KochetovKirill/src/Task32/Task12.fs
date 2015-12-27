module Task3212

open Task31
open Task30
open Task15
open Task3211

let rec reverse (n : MyList<int>) = 
    match n with
    | Empty -> Empty
    | Cons(head, tail) ->
        (reverse tail).addListToTheEnd (Cons(head, Empty))

let isMod2Eq0 (n : Num) =
    match n with
    | (sign, abs) ->
        match reverse abs with
        | Empty -> failwith "Empty"
        | Cons(hd, tail) ->
            hd % 2 = 0

let division2 (n : Num) =
    match n with
    | (sign, abs) ->
        let div (t : MyList<int>) =
            let rec divis (a : MyList<int>) (ost : int) = 
                match a with
                | Empty -> Empty
                | Cons(head, tail) ->
                    Cons((head + 10 * ost - (head % 2)) / 2, divis tail (head % 2))
                    
            match t with
            | Empty -> Empty
            | Cons(head, tail) ->
                if head < 2
                then
                    match tail with
                    | Empty ->
                        Cons(head, tail)
                    | Cons(hd, tl) ->
                        divis tail (head % 2)
                else
                    divis t 0
        (sign, reverse(div(reverse abs)))
    

let rec Fib (Arr : Num[,]) (n : Num) =
    if n = (1, Cons(1, Empty)) || n = (1, Cons(0, Empty))
    then
        Arr
    else
        if isMod2Eq0 n 
        then
            let ret = Task3211.mult (Fib Arr (division2 n) ) (Fib Arr (division2 n) )
            ret
        else
            let rc = Task3211.mult (Fib Arr (division2 (sum n (-1, Cons(1, Empty))))) (Fib Arr (division2 (sum n (-1, Cons(1, Empty)))))
            let ret = Task3211.mult Arr rc
            ret
 
let main (n : Num) = 
    let mtrx = array2D [ [ (1, Cons(1, Empty)); (1, Cons(1, Empty)) ] ; [ (1, Cons(1, Empty)); (1, Cons(0, Empty)) ] ]
    let fibn = Fib mtrx (sum n (-1, Cons(1, Empty)))
    fibn.[0,0]
