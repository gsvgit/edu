module Task16

type MyList 'a =
    | Empty: MyList 'a
    | Smth: 'a -> MyList 'a -> MyList 'a
            
type nat0 = x:int{x>=0}

val main: MyList 'a -> Tot nat0
let rec main lst =
  match lst with
  | Empty -> 0
  | Smth _ xs -> 1 + main xs
                       
