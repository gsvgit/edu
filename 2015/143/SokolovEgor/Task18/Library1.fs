module Task18

open Task17

let main string =
    let rec sum (str:string) result i =
        if i < 0 then result
        else sum str (Str (str.[i], result)) (i-1)
    sum string Empty (string.Length-1)