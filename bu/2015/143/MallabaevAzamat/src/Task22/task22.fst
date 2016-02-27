module Task22

open Task15

val where: MyList 'a -> ('a -> Tot bool) -> Tot (MyList 'a)
let rec where lst pred =
  match lst with
  | Empty -> Empty
  | Smth x xs -> if pred x then Smth x (where xs pred) else (where  xs pred)

val merge: MyList 'a -> MyList 'a -> Tot (MyList 'a)
let rec merge fl sl =
  match fl with
  | Empty -> sl
  | Smth x xs -> Smth x (merge xs sl)

val quickSort: MyList int -> Tot (MyList int)
let quickSort lst =
  match lst with
  | Empty -> Empty
  | Smth x xs -> merge (where xs (fun it -> it < x)) (Smth x (where xs (fun it -> it > x)))
