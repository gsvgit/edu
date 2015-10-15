module Task18
open Task17
open Task15

let toMyString (str : string) = 
    let mystr : MyString = Empty
    let rec tms (lst : MyString) (str : string) i =
        if i <= str.Length
        then tms (lst.add(str.[str.Length-i])) str (i + 1)
        else lst
    tms mystr str 1