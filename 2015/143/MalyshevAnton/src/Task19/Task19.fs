module Task19

open Task15

type num = int

type Tree =
    | Node of int * MyList<Tree>
    | Leaf of int

let rec main (tree: Tree) =

    let rec maxminList (list: MyList<Tree>) =

        match list with
        | Cons(tree, subList) ->  
            let (maximal, minimal) = maxminList subList
            (max (fst (main tree)) maximal, min (snd (main tree)) minimal)
        | Empty -> (num.MinValue, num.MaxValue)

    match tree with
    | Leaf(a) -> (a, a)
    | Node(a, list) ->
        let (maximal, minimal) = maxminList list
        (max a maximal, min a minimal)