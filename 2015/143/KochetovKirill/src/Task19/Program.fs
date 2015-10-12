//module Task19
//
//open Task15
//
//  type Tree = 
//  |Node of int * List<Tree>
//  |Leaf of int
//
//  let main tr =
//    match tr with
//    |Leaf vl -> (vl, vl)
//    |Node (vl, lst) ->
//      let rec lister lst (mn, mx) = 
//        match lst with
//        |Empty -> (mn, mx)
//        |Cons (tr, ls) -> lister ls (trier (mn, mx))