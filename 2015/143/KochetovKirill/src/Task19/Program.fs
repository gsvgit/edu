module Task19

open Task15

type Tree = 
|Node of int * List<Tree>
|Leaf of int

let main tr =
  match tr with
  |Leaf vl -> (vl, vl)
  |Node (vl, lst) ->
    let rec trier tre ((mn, mx), is) =
      let rec lister lest ((men, mex), isi) =
        match lest with
        |Empty -> ((men, mex), isi)
        |Cons (tere, stl) -> lister stl (trier tere ((men, mex), isi))
      match tre with
      |Leaf vl ->
        if is
        then
          if vl < mn then ((vl, mx), is)
          elif vl > mx then ((mn, vl), is)
          else ((mn,mx), is)
        else
          ((vl, vl), true)
      |Node (vl, lst) ->
//        if vl < mn then lister lst (vl, mx)
//        elif vl > mx then lister lst (mn, vl)
//        else lister lst (mn, mx)
          lister lst ((mn, mx), is)
    match trier tr ((vl, vl), false) with
    |((mn, mx), is) -> (mn, mx)

[<EntryPoint>]
let inter argv = 
  printfn "%A" <| main (Node(6, Cons(Node (1, Cons(Leaf 7, Cons(Leaf 8, Cons(Leaf 3, Empty)))), Cons(Leaf 2, Cons(Leaf 3, Empty)))))
  let rk = System.Console.ReadKey(true)
  0