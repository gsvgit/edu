module Task30
open Task15

type Num = int * MyList<int>

let sum (num1 : Num) (num2 : Num) =

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

    let rec compare (num1 : MyList<int>) (num2 : MyList<int>) =
        if num1.getLength() > num2.getLength()
        then Some(true)
        elif num2.getLength() > num1.getLength()
        then Some(false)
        else
        match num1, num2 with
        | Empty, Empty -> None
        | Cons (hd1, tl1), Cons (hd2, tl2) ->
            if hd1 > hd2
            then Some(true)
            elif hd2 > hd1
            then Some(false)
            else compare tl1 tl2 
        | Cons (hd1, myList1), Empty -> Some(true)
        | Empty, Cons (hd2, myList2) -> Some(false)          
                                                        
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
                         
    let rec zeroDelete num =
        match num with
        | Empty -> Empty
        | Cons (0, Empty) -> Cons (0, Empty)
        | Cons (hd, tl) ->
            if hd = 0
            then zeroDelete tl
            else Cons (hd, tl)  
    
    match num1 with
        | s1, n1 ->    
            match num2 with
            | s2, n2 ->                             
                let compr = compare n1 n2
                if s1 = s2
                then 
                    s1, addition (reverse n1) (reverse n2) 0 1 1 |> reverse |> zeroDelete
                elif s1 = 1 && s2 = -1 && compr = Some(true)
                then 
                    1, addition (reverse n1) (reverse n2) 0 1 -1 |> reverse |> zeroDelete
                elif s1 = 1 && s2 = -1 && compr = Some(false)
                then 
                    -1, addition (reverse n1) (reverse n2) 0 -1 1 |> reverse |> zeroDelete
                elif s1 = -1 && s2 = 1 && compr = Some(true)
                then 
                    -1, addition (reverse n1) (reverse n2) 0 1 -1 |> reverse |> zeroDelete
                elif s1 = -1 && s2 = 1 && compr = Some(false)
                then 
                    1, addition (reverse n1) (reverse n2) 0 -1 1 |> reverse |> zeroDelete
                else 1, Cons(0, Empty)

