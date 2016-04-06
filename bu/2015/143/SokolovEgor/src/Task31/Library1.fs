module Task31

open Task30
open Task15
let mult (list1 : Num) (list2 : Num) = 
   
    let rec add list1 list2 ost sign1 sign2 =
        match list1, list2 with
        | Empty, Empty -> 
            if ost = 0 
            then Empty
            else Cons (ost, Empty)
        | Cons (hd1, myList1), Cons (hd2, myList2) ->                 
            let sum1 = hd1 * sign1 + hd2 * sign2 + ost 
            if sum1 > 9 
            then Cons (sum1 % 10, add myList1 myList2 (sum1 / 10) sign1 sign2)
            else Cons (sum1, add myList1 myList2 (sum1 / 10) sign1 sign2)                                                                     
        | Cons (hd1, myList1), Empty 
        | Empty, Cons (hd1, myList1) ->                 
            let sum2 = hd1 * 1 + ost 
            if sum2 > 9 
            then Cons (sum2 % 10, add  myList1 Empty (sum2 / 10) sign1 sign2)
            else Cons (sum2, add myList1 Empty (sum2 / 10) sign1 sign2)  

    let rec reverse (lst: MyList<int>) =
        let rec last lst =
            match lst with
            | Cons (hd, Empty) -> hd
            | Cons (hd, tl) -> last tl
            | Empty -> 0
        let rec cut lst =
            match lst with 
            | Cons (hd, Empty) -> Empty
            | Cons (hd, tl) -> Cons (hd, cut tl)
            | Empty -> Empty
        match lst with
        | Empty -> Empty
        | Cons (hd, tl) -> Cons (last lst, reverse (cut lst))    

    let rec zero list =
        match list with
        | Cons (0, Empty) -> Cons (0, Empty)
        | Empty -> Empty
        | Cons (hd, myList) ->
            if hd = 0
            then zero myList
            else Cons (hd, myList)

    let rec mult hd list od discharge =
        if discharge > 0
        then Cons (0, mult hd list od (discharge - 1))
        else
            match list with
            | Empty ->
                if od > 0 
                then Cons (od, Empty)
                else Empty
            | Cons (hd3, myList) ->                   
                let mul = hd * hd3 + od
                if mul > 9 
                then Cons (mul % 10, mult hd myList (mul / 10) 0) 
                else Cons (mul, mult hd myList 0 0)

    let rec multi list1 list2 ds =
        match list2 with
        | Empty -> Empty
        | Cons (hd4, myList) ->
            add (mult hd4 list1 0 ds) (multi list1 myList (ds + 1) ) 0 1 1 
        
    match list1 with
    | sign1, list1 ->    
       match list2 with
       | sign2, list2 -> 
           if sign1 = sign2
           then 1, multi (reverse list1) (reverse list2) 0 |> reverse |> zero
           else -1, multi (reverse list1) (reverse list2) 0 |> reverse |> zero