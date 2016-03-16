module Task15

type MyList 'a =
    | Empty: MyList 'a
    | Smth: 'a -> MyList 'a -> MyList 'a

val foldU: MyList 'a -> 'b -> ('b -> Tot 'b) -> Tot 'b
let rec foldU lst acc f =
  match lst with
  | Empty -> acc
  | Smth x xs -> foldU xs (f acc) f
