module Task18

open Task15
open Task17

let toMyString string =
    let rec sum (str:string) result i =
        if i < 0 
        then 
            result
        else 
            sum str (Cons (str.[i], result)) (i - 1)
    sum string Empty (string.Length - 1)