module Task31

open Task15
open Task30

val add: Num -> Tot (Num -> Tot Num)
let add f s = sum f s

val un: Num -> Tot Num
let un n =
  match n with
  | Pos x -> Neg x
  | Neg x -> Pos x

val mul: Num -> Num -> Tot Num
let mul f s =
  match f with
  | Pos n -> foldU n (Pos Empty) (add s)
  | Neg n -> un (foldU n (Pos Empty) (add s))
