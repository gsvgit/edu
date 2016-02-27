module Task26

open Task15

type Tape = Task15.MyList<char>
type Rules = Task15.MyList<Tape * Tape>

let strtotape (str : string) =
    let tape = Empty
    let rec stt (tp : Tape) (str : string) i =
        if i <= str.Length
        then stt (tp.add(str.[str.Length - i])) str (i + 1)
        else tp
    stt tape str 1 

let rec checker (pattern : Tape) (tape : Tape) = 
    match pattern, tape with
    | Empty, _ -> true
    | Cons(a, atl), Cons(b, btl) ->
        if a = b
        then checker atl btl
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
        if checker first tape
        then
            merge second (rulecheck (first, second) (cut tape (first.length())) )
        else
            merge (Cons(ch, Empty) ) (rulecheck (first, second) tail)

let rec interpretator (rules : Rules) (tape : Tape) = 
    match rules with
    | Empty -> tape
    | Cons(rule, grtl) ->
        interpretator grtl (rulecheck rule tape)

let rec reader (rules : Rules) = 
    let string = System.Console.ReadLine()
    let first = strtotape string
    match System.Console.ReadLine() with
    | "" -> (rules, first)
    | second -> reader (rules.addListToTheEnd(Cons((first, strtotape second), Empty))) 

[<EntryPoint>]
let inter argv = 
    match reader Empty with
    | (rules, tape) ->
        printfn "%A" <| (interpretator rules tape)
    let rk = System.Console.ReadKey(true)
    0