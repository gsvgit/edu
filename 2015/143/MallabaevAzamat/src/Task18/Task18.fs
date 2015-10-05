module Task18

open Task15
open Task17

let toMyString (str: string): MyString =
  let rec _toMyString i l =
    if i < l then Cons(str.[i], (_toMyString (i+1) l))
    else Nil
  _toMyString 0 str.Length
  
let rec (==) (a: char List) (b: char List):bool =
  match a with
  | Nil ->
    match b with
    | Nil -> true
    | _ -> false
  | Cons(ah, at) ->
    match b with
    | Cons(bh, bt) -> (ah = bh) && (at = bt)
    | _ -> false