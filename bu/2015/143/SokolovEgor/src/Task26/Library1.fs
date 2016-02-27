module Task26
open Task15

type Tape = Task15.MyList<char>
type Grammar = Task15.MyList<Tape * Tape>

let parse (str : string) =
    let tape = Empty
    let rec st (tp : Tape) (str : string) i =
        if i <= str.Length
        then st (tp.addIn(str.[str.Length - i])) str (i + 1)
        else tp
    st tape str 1 


let rec check (pattern : Tape) (tape : Tape) = 
    match pattern, tape with
    | Empty, _ -> true
    | Cons(a, atl), Cons(b, btl) ->
        if a = b
        then check atl btl
        else false
    | _, Empty -> false

let rec merge (a : Tape) (b : Tape) =
    match a with
    | Empty -> b
    | Cons(hd, tl) -> Cons(hd, merge tl b)

let rec cut (a : Tape) (len : int) =
    if len > 0
    then
        match a with
        | Empty -> Empty
        | Cons(hd, tl) -> cut tl (len - 1)
    else
        a

let rec rulecheck ( (first : Tape), (second : Tape) ) (tape : Tape) =
    match tape with
    | Empty -> Empty
    | Cons(ch, tail) ->
        if check first tape
        then
            merge second (rulecheck (first, second) (cut tape (first.length())) )
        else
            merge (Cons(ch, Empty) ) (rulecheck (first, second) tail)

let rec interpr (grammar : Grammar) (tape : Tape) = 
    match grammar with
    | Empty -> tape
    | Cons(rule, grtl) ->
        interpr grtl (rulecheck rule tape)


let rec reader (grammar : Grammar) = 
    let string = System.Console.ReadLine()
    let first = parse string
    match System.Console.ReadLine() with
    | "" -> (grammar, first)
    | second -> reader (grammar.add(Cons((first, parse second), Empty))) 

let main (string : string) =
    match reader Empty with
    | (grammar, tape) -> 
        printfn "%A" (interpr grammar tape)