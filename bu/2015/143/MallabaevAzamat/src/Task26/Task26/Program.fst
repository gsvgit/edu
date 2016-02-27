module Test

type Result 'a 'b 'c =
    | Ok: 'a -> 'c -> Result 'a 'b 'c
    | Fail: 'b -> 'c -> Result 'a 'b 'c

type List 'a =
    | Empty: List 'a
    | Cons: 'a -> List 'a -> List 'a

type String = List char

type Parser 'result = String -> Result 'result String String

val merge: List 'a -> List 'a -> Tot (List 'a)
let rec merge a b =
  match a with
  | Empty -> b
  | Cons h t -> Cons h (merge t b)

val andP: Parser 'a -> Parser 'b -> ('a -> 'b -> Tot 'c) -> Tot (Parser 'c)
let andP pa pb participator = fun str ->
  match pa str with
  | Ok okra tail ->
    (match pb tail with
     | Ok okrb tailend -> Ok (participator okra okrb) tailend
     | Fail msg tailend -> Fail msg tailend
    )
  | Fail msg tail -> Fail msg tail

val orP: Parser 'a -> Parser 'a -> Tot (Parser 'a)
let orP pa pb = fun str ->
  match pa str with
  | Fail msg tail ->
    (match pb tail with
     | Ok okrb tailend -> Ok okrb tailend
     | Fail msg tailend -> Fail msg tailend
    )
  | Ok okra tail -> Ok okra tail

val oneP: Parser 'a -> Tot (Parser (List 'a))
let oneP p = fun str ->
  match p str with
  | Ok head tail -> Ok (Cons head Empty) tail
  | Fail msg tail -> Fail msg tail
  
val zeroP: Parser 'a -> Tot (Parser (List 'a))
let zeroP p = fun str -> Ok Empty str

val manyP: Parser 'a -> Tot (Parser (List 'a))
let rec manyP p str =
  match p str with
  | Fail msg tail -> Fail msg str
  | Ok okra tail ->
    match p tail with
    | Ok okrb tailend -> Ok (Cons okra (Cons okrb Empty)) tailend
    | Fail msg tailend -> Ok (Cons okra Empty) tailend

val charP: (char -> Tot bool) -> Tot (Parser char)
let charP ch = function
  | Empty -> Fail Empty Empty
  | Cons h t -> if ch h then Ok h t else Fail Empty (Cons h t)
  
val ischarP: char -> Tot (Parser char)
let ischarP ch = charP (fun c -> ch = c)

val isncharP: char -> Tot (Parser char)
let isncharP ch = charP (fun c -> ch <> c)

val seq: String -> Tot (Parser String)
let rec seq str =
  match str with
  | Empty -> fun t -> Ok Empty t
  | Cons h t -> andP (ischarP h) (seq t) (Cons)
  
val pattern: Parser String
let pattern = manyP (isncharP '\n')

val first: 'a -> 'b -> Tot 'a
let first a b = a

val pair: 'a -> 'b -> Tot ('a * 'b)
let pair a b = (a, b)

val rule: Parser (String * String)
let rule = (andP (andP (andP pattern (ischarP '\n') first) pattern pair) (ischarP '\n') first)

val grammar: Parser (List (String * String))
let grammar = manyP rule

type nat0 = x:int{x>=0}

val len: List 'a -> Tot nat0
let rec len lst =
  match lst with
  | Empty -> 0
  | Cons _ t -> 1 + len t

val cut: List 'a -> nat0 -> Tot (List 'a)
let rec cut lst l =
  if l > 0
  then
    match lst with
	| Empty -> Empty
	| Cons h t -> cut t (l - 1)
  else lst

val length: List 'a -> Tot nat0
let rec length = function
  | Empty -> 0
  | Cons h t -> 1 + length t

val test: l:String -> String -> Tot bool (decreases (length l))
let rec test pattern tape =
  match pattern, tape with
  | Empty, _ -> true
  | Cons x xs, Cons y ys -> if x = y then test xs ys else false
  | _ -> false

val interp: l:List (String * String) -> String -> Tot String (decreases (length l))
let rec interp grammar tape =
  match grammar with
  | Empty -> tape
  | Cons (pattern, value) t -> if test pattern tape then merge value (cut tape (len pattern)) else interp t tape

val ended_grammar: List (String * String) -> List String -> Tot bool
let rec ended_grammar lst rules =
  match lst, rules with
  | Empty, _ -> true
  | Cons (_, Empty) tl, _ -> ended_grammar tl rules
  | Cons (p, v) tl, Cons r tr -> if test r v then false else ended_grammar tl (Cons p rules)
  | Cons (p, v) tl, Empty -> ended_grammar tl (Cons p Empty)

val interp_gen: lst:(List (String * String)){ended_grammar lst Empty} -> String -> String
let rec interp_gen grammar tape =
  match interp grammar tape with
  | tadam -> if (test tape tadam) || (test tadam tape) then tadam else interp_gen grammar tadam