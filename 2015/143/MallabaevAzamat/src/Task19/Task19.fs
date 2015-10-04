module Task19

open Task15

type 'a Tree =
| Leaf of 'a
| Node of 'a * 'a Tree List
             
let rec max_min tree =
  let rec _max_min tree_list (max, min) =
    match tree_list with
    | Nil -> (max, min)
    | Cons(x, s) ->
        let (m1, m2) = max_min x
        _max_min s ((if m1 > max then m1 else max), (if m2 < min then m2 else min))

  match tree with
  | Leaf(x) -> (x, x)
  | Node(x, s) -> _max_min s (x, x)
