module Task19
open Task15

type Tree = 
    | Node of int * MyList<Tree>
    | Leaf of int

let main tr =
    match tr with
    | Leaf vl -> (vl, vl)
    | Node (vl, lst) ->
        let rec trier tre ((mn, mx), is) =
            let rec lister lest ((men, mex), isi) =
                match lest with
                | Empty -> ((men, mex), isi)
                | Cons (tere, stl) -> lister stl (trier tere ((men, mex), isi))
            match tre with
            | Leaf vl ->
                if is
                then
                    if vl < mn then ((vl, mx), is)
                    elif vl > mx then ((mn, vl), is)
                    else ((mn, mx), is)
                else
                    ((vl, vl), true)
            | Node (vl, lst) ->
                lister lst ((mn, mx), is)
        match trier tr ((vl, vl), false) with
        | ((mn, mx), is) -> (mn, mx)