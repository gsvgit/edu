module Test

type Result 'a 'b 'c =
    | Ok: 'a -> 'c -> Result 'a 'b
    | Fail: 'b -> 'c -> Result 'a 'b

type List 'a =
    | Empty: List 'a
    | Cons: 'a -> List 'a -> List 'a

type String = List char

type Parser 'result = String -> Result 'result String String

val merge: List 'a -> List 'a -> Tot List 'a
let rec merge a b =
  match a with
  | Empty -> b
  | Cons h t -> Cons h (merge t b)

val andp: Parser 'a -> Parser 'b -> ('a -> 'b -> 'c) -> Tot Parser 'c
let andp p1 p2 t =
  fun str ->
    match p1 str with
    | Ok ar oth ->
      match p2 oth with
	    | Ok br noth -> Ok (t ar br) noth
	    | Fail msg noth -> Fail msg noth
    | Fail msg oth -> Fail msg oth

val orp: Parser 'a -> Parser 'a -> Tot Parser 'a
let orp p1 p2 t = fun str ->
  match p1 str with
  | Fail msg oth ->
    match p2 oth with
	  | Fail nmsg noth -> Fail (merge msg nmsg) noth
    | no -> no
  | o -> o

val many: Parser 'a -> Tot Parser List 'a
let rec many p = orp (andp p (many p) (fun a b -> Cons a b)) p

val char: (char -> Tot bool) -> Tot Parser char
let char ch = function
  | Empty -> Fail (toString "EOF") Empty
  | Cons h t -> if ch t then Ok h t
  
val ischar: char -> Tot Parser char
let ischar ch = char (fun c -> ch = c)

val isnchar: char -> Tot Parser char
let isnchar ch = char (fun c -> ch <> c)

val seq: List 'a -> Tot Parser List 'a
let rec seq str =
  match str with
  | Empty -> fun t -> Ok Empty t
  | Cons h t -> andp (ischar h) (seq t) (fun a b -> Cons a b)
  
val pattern1: Parser String
let pattern1 = many (isnchar '-')

val pattern2: Parser String
let pattern2 = many (isnchar '\n')

val rule: Parser (String * String)
let rule = (andp (andp (andp pattern1 (seq (Cons '-' (Cons '>' Empty)))) pattern2) (ischar '\n'))

val grammar: Parser List (String * String)
let grammar = many rule

val pat: List 'a -> List 'a -> Tot bool
let rec pat p v =
  match p with
  | Empty -> true
  | Cons h t ->
    match v with
	  | Empty -> false
  	| Cons ho to -> (ho = h) && (pat t to)

type nat0 = x:int{x>=0}

val len: List 'a -> Tot nat0
let rec len lst =
  match lst with
  | Empty -> 0
  | Cons _ t -> 1 + len t

val cut: List 'a -> nat0 -> Tot List 'a
let rec cut lst l =
  if l > 0
  then
    match lst with
	| Empty -> Empty
	| Cons h t -> cut t (l - 1)
  else lst

val interp: List (String * String) -> String -> Tot String
val interp grammar tape =
  match grammar with
  | Empty -> tape
  | Cons h t -> if pat h tape then cut (len h) tape else interp t tape

val interp_gen: List (String * String) -> String -> Tot String
let interp_gen grammar tape =
  match interp garmmar tape with
  | Empty -> Empty
  | tadam -> if tadam = tape then tadam else interp_gen grammar tadam