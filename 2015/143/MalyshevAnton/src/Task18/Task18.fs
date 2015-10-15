module Task18

open Task17

let toMyString string =
    let rec DoList (str: string) lst s =
        if s > String.length string - 1
        then
            lst
        else
            String(str.[s], (DoList str lst (s + 1)))
    DoList string Empty 0