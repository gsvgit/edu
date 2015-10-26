module Task19

open Task15

type Tree =
    | Node of int * MyList<Tree>
    | Leaf of int

let main tree =
    let init tree =
        match tree with
        | Leaf (s1) -> s1
        | Node (s1, tree) -> s1

    let rec findMax tree max =
        match tree with
        | Leaf (s1) -> 
            if s1 > max 
            then s1
            else max
        | Node (s1, tree) ->
            let rec findLocalMax tree localMax =
                match tree with
                | Empty -> localMax
                | Cons (hd, tl) ->
                    findMax hd (findLocalMax tl localMax)
            if s1 > findLocalMax tree max
            then s1
            else findLocalMax tree max

    let rec findMin tree min =
        match tree with
        | Leaf (s1) -> 
            if s1 < min 
            then s1
            else min
        | Node (s1, tree) ->
            let rec findLocalMin tree localMin =
                match tree with
                | Empty -> localMin
                | Cons (hd, tl) ->
                    findMin hd (findLocalMin tl localMin)
            if s1 < findLocalMin tree min
            then s1
            else findLocalMin tree min

    findMax tree (init tree), findMin tree (init tree)