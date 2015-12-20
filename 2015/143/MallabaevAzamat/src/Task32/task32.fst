module Task32

open Task15
open Task30
open Task31

val isPos: Num -> Tot bool
let isPos n =
  match n with
  | Neg Empty
  | Pos _ -> true
  | _ -> false

val toNat: x:int{x >= 0} -> Tot (y:Num{isPos y})
let rec toNat n =
  match n with
  | 0 -> Pos Empty
  | _ -> inc (toNat (n - 1))

val toNum: int -> Tot Num
let rec toNum n =
  match n with
  | 0 -> Pos Empty
  | _ -> if n > 0
         then inc (toNat (n - 1))
         else un (inc (toNat (- n - 1)))

val unBool: bool -> Tot bool
let unBool n =
  match n with
  | true -> false
  | false -> true

val isDivBy2: Num -> Tot bool
let isDivBy2 n =
  match n with
  | Pos xs -> foldU xs true unBool
  | Neg xs -> foldU xs true unBool
