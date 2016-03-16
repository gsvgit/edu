module Task18

open Task15
open Task17

let rec toMyString (str: string) =
    if str.Length = 0
    then Empty
    else Smth (str.[0], toMyString (str.Substring(1)))