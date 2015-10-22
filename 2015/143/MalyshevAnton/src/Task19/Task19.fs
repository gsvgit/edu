module Task19

open Task15

type Tree =
    | Node of int * List<Tree>
    | Leaf of int