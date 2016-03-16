module Task19

open Task15

type Tree =
    | Node of int * MyList<Tree>
    | Leaf of int

let rec main tree =
    let rec localFinder (list: MyList<Tree>) =
        match list with
        | Cons(hd, tl) ->
            let (maximal, minimal) = localFinder tl
            (max(fst (main hd)) maximal, min(snd (main hd)) minimal)
        | Empty -> (System.Int32.MinValue, System.Int32.MaxValue)

    match tree with
    | Leaf(s1) -> (s1, s1)
    | Node(s1, list) ->
        let (maximal, minimal) = localFinder list
        (max s1 maximal, min s1 minimal)