module Task18

open Task17

let toMyString (str: string) =
  let rec _toMyString i l =
    if i < l then str.[i].ToString() + (_toMyString (i+1) l)
    else ""
  _toMyString 0 str.Length
