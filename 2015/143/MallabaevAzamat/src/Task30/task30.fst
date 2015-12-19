module Task30

open Task15

type Num =
  | Pos: MyList unit -> Num
  | Neg: MyList unit -> Num

val inc: Num -> Tot Num
let inc f =
  match f with
  | Neg Empty -> Pos (Smth () Empty)
  | Neg (Smth () n) -> Neg n
  | Pos n -> Pos (Smth () n)

val dec: Num -> Tot Num
let dec f =
  match f with
  | Pos Empty -> Neg (Smth () Empty)
  | Pos (Smth () n) -> Pos n
  | Neg n -> Neg (Smth () n)

val sum: Num -> Num -> Tot Num
let sum f s =
  match f with
  | Pos n -> foldU n s inc
  | Neg n -> foldU n s dec
