module Task30

open Task15

let rec listLength lst =
    match lst with
    | Empty -> 0
    | Cons (_, t) -> 1 + listLength t

type Num = 
    int * MyList<int>

let sum (list1 : Num) (list2 : Num) =

    let rec compres list1 list2 =
        if listLength list1 > listLength list2
        then 1
        elif listLength list2 > listLength list1
        then 2
        else
        match list1, list2 with
        | Empty, Empty -> 0
        | Cons (hd1, myList1), Cons (hd2, myList2) ->
            if hd1 > hd2
            then 1
            elif hd2 > hd1
            then 2
            else compres myList1 myList2
        | Cons (hd1, myList1), Empty -> 1
        | Empty, Cons (hd2, myList2) -> 2            
                                                        
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
            elif sum1 >= 0 && sum1 < 10
            then Cons (sum1, add myList1 myList2 (sum1 / 10) sign1 sign2)                                                           
            else Cons (10 + sum1, add myList1 myList2 -1 sign1 sign2)                   
        | Cons (hd1, myList1), Empty 
        | Empty, Cons (hd1, myList1) ->                 
            let sum2 = hd1 * 1 + ost 
            if sum2 > 9 
            then Cons (sum2 % 10, add  myList1 Empty (sum2 / 10) sign1 sign2)
            else Cons (sum2, add myList1 Empty (sum2 / 10) sign1 sign2)  
                         
    let rec zero lst =
        match lst with
        | Cons (0, Empty) -> Cons (0, Empty)
        | Empty -> Empty
        | Cons (hd, myList) ->
            if hd = 0
            then zero myList
            else Cons (hd, myList)  
    
    match list1 with
    | sign1, list1 ->    
        match list2 with
        | sign2, list2 ->        
            
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
                                   
            let compr = compres list1 list2
            if sign1 = sign2
            then 
                sign1, add (reverse list1) (reverse list2) 0 1 1 |> reverse |> zero
            elif sign1 = 1 && sign2 = -1 && compr = 1
            then 
                sign1, add (reverse list1) (reverse list2) 0 1 -1 |> reverse |> zero
            elif sign1 = 1 && sign2 = -1 && compr = 2
            then 
                sign2, add (reverse list1) (reverse list2) 0 -1 1 |> reverse |> zero
            elif sign1 = -1 && sign2 = 1 && compr = 1
            then 
                sign1, add (reverse list1) (reverse list2) 0 1 -1 |> reverse |> zero
            elif sign1 = -1 && sign2 = 1 && compr = 2
            then 
                sign2, add (reverse list1) (reverse list2) 0 -1 1 |> reverse |> zero
            else 
                1, Cons(0, Empty)
