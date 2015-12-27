module Task31

open Task15
open Task30
    
let multiplication (num1 : Num)  (num2 : Num) = 
    
    let rec reverse lst =
        let rec lastOf lst =
            match lst with
            | Empty -> 0
            | Cons (hd, Empty) -> hd
            | Cons (hd, tl) -> lastOf tl
        let rec cut lst =
            match lst with 
            | Empty -> Empty
            | Cons (hd, Empty) -> Empty
            | Cons (hd, tl) -> Cons (hd, cut tl)
        match lst with
        | Empty -> Empty
        | Cons (hd, tl) -> Cons (lastOf lst, reverse (cut lst))

    let rec zeroDelete num =
        match num with
        | Empty -> Empty
        | Cons (0, Empty) -> Cons (0, Empty)
        | Cons (hd, tl) ->
            if hd = 0
            then zeroDelete tl
            else Cons (hd, tl) 

    let rec addition num1 num2 ost s1 s2 =
        match num1, num2 with
        | Empty, Empty -> 
            if ost = 1 
            then Cons (1, Empty) 
            else Empty   
        | Cons (hd1, tl1), Cons (hd2, tl2) ->                 
            let hd = hd1 * s1 + hd2 * s2 + ost 
            if hd > 9  
            then Cons (hd - 10, addition tl1 tl2 1 s1 s2)                                  
            elif hd < 0 
            then Cons (hd + 10, addition tl1 tl2 -1 s1 s2)                                 
            else Cons (hd, addition tl1 tl2 0 s1 s2) 
        | Cons (hd1, tl1), Empty -> 
            let hd = hd1 * s1 + ost 
            if hd > 9 
            then Cons (hd - 10, addition tl1 Empty 1 s1 s2)
            elif hd < 0 
            then Cons (hd + 10, addition tl1 Empty -1 s1 s2)
            else Cons (hd, tl1) 
        | Empty, Cons (hd2, tl2) ->                 
            let hd = hd2 * s2 + ost
            if hd > 9 
            then Cons (hd - 10, addition tl2 Empty 1 s1 s2)
            elif hd < 0 
            then Cons (hd + 10, addition tl2 Empty -1 s1 s2)
            else Cons (hd, tl2) 
             
    let rec multToNum hd num ost digit =
        if digit > 0
        then Cons (0, multToNum hd num ost (digit - 1))
        else
            match num with
            | Empty ->
                if ost > 0 
                then Cons (ost, Empty)
                else Empty
            | Cons (hd1, tl1) ->                   
                let comp = hd * hd1 + ost
                if comp > 9 
                then Cons (comp % 10, multToNum hd tl1 (comp / 10) 0) 
                else Cons (comp, multToNum hd tl1 0 0)

    let rec multInNums num1 num2 digit =
        match num2 with
        | Empty -> Empty
        | Cons (hd2, tl2) ->
            addition (multToNum hd2 num1 0 digit) (multInNums num1 tl2 (digit + 1) ) 0 1 1 
 
    match num1 with 
    | s1, n1 ->
        match num2 with
        | s2, n2 ->
            if s1 = s2
            then 1, multInNums (reverse n1) (reverse n2) 0 |> reverse |> zeroDelete
            else -1, multInNums (reverse n1) (reverse n2) 0 |> reverse |> zeroDelete