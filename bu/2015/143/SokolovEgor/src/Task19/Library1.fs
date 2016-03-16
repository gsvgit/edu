module Task19

open Task15

type Tree = 
    | Node of int * MyList<Tree>
    | Leaf of int

let main treeB =
    let init tree =
        match tree with
        | Leaf (sign) -> sign
        | Node (sign, tree) -> sign

    let rec min treeInput minimum =
        match treeInput with
        | Leaf (sign) -> 
            if sign > minimum 
            then minimum
            else sign
        | Node (sign, tree) ->
            let rec minInLst tree minimumInLst =
                match tree with
                | Empty -> minimumInLst
                | Cons (head, tale) ->
                    min head (minInLst tale minimumInLst)
            if sign < minInLst tree minimum 
            then sign
            else minInLst tree minimum
    let rec max treeInput maximum =
        match treeInput with
        | Leaf (sign) -> 
            if sign < maximum 
            then maximum
            else sign
        | Node (sign, tree) ->
            let rec maxInLst tree maximumInLst =
                match tree with
                | Empty -> maximumInLst
                | Cons (head, tale) -> max head (maxInLst tale maximumInLst)
            if sign > maxInLst tree maximum 
            then sign
            else maxInLst tree maximum
    max treeB (init treeB), min treeB (init treeB)