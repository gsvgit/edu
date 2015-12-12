module Task16

open Task15
        
type nat0 = x:int{x>=0}

val main: MyList 'a -> Tot nat0
let rec main lst =
    match lst with
    | Empty -> 0
    | Smth _ xs -> 1 + main xs
                       
