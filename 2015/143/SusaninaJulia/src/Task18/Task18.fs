module Task18

open Task15
open Task17

let toMyString str = 
    let rec tms (str:string) (lst:MyString) (t:int) = 
        let leng = String.length(str)
        if t < leng
        then tms str (lst.addToTheEnd(str.[t])) (t+1)
        else lst
    tms str Empty 0