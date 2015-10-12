module Task16

open Task15

let rec main lst =
  match lst with
  | Nil -> 0
  | Cons(_, t) -> 1 + main t