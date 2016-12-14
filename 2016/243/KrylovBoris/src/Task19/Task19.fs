module Task19

open Task15

type Tree =
    | Node of int * MyList<Tree>
    | Leaf of int

  let main t =
    match t with
        |Leaf vl -> (vl, vl)
        |Node (hd, tl) ->
            let rec search tre ((min, max), i) =
                let rec lis lst ((mn, mx), cond) =
                    match lst with
                    |Empty -> 
                        ((mn, mx), cond)
                    |Cons(hd, tl) -> 
                        lis tl (search hd ((mn, mx), cond))
                match tre with
                |Leaf vl ->
                    if (i)
                    then
                        if vl < min then ((vl, max), i)
                        elif vl > max then ((min, vl), i)
                        else ((min, max), i)
                    else
                        ((vl,vl), true)
                |Node(hd, lt) -> 
                    lis lt ((min, max), i)
            match search t ((hd, hd), false) with
            |((min, max), i) -> (min, max)