module Task26

open Task15

type Tape = Task15.MyList<char>
type Grammar = Task15.MyList<Tape * Tape>

//парсер короч
let strtotape (str : string) =
    let tape = Empty
    let rec stt (tp : Tape) (str : string) i =
        if i <= str.Length
        then stt (tp.add(str.[str.Length - i])) str (i + 1)
        else tp
    stt tape str 1 


//проверяет есть ли в начале ленты tape лента pattern
let rec checker (pattern : Tape) (tape : Tape) = 
    match pattern, tape with
    | Empty, _ -> true
    | Cons(a, atl), Cons(b, btl) ->
        if a = b
        then checker atl btl
        else false
    | _, Empty -> false

//let rec rulecheck (grammar : Grammar) (tape : Tape) =
//    match grammar, tape with
//    | Empty, _ -> tape
//    | Cons((first, second), nextgrammar), (ch, tail) ->
//        if checker first tape
//        then
//            merge second (rulecheck grammar )


//короч добавляет в начало ленты b ленту a (или в конец a добавляет b)
let rec merge (a : Tape) (b : Tape) =
    match a with
    | Empty -> b
    | Cons(hd, tl) -> Cons(hd, merge tl b)

//этот почан короч обрезает ленту a с начала на заданную длинну len
let rec cut (a : Tape) (len : int) =
    if len > 0
    then
        match a with
        | Empty -> Empty
        | Cons(hd, tl) -> cut tl (len - 1)
    else
        a
//а эта херня короч применяет одно правило (first, second) на ленту tape (ну короч везде где можно заменяет first на second)
let rec rulecheck ( (first : Tape), (second : Tape) ) (tape : Tape) =
    match tape with
    | Cons(ch, tail) ->
        if checker first tape
        then
            merge second (rulecheck (first, second) (cut tape (first.length())) )
        else
            merge (Cons(ch, Empty) ) (rulecheck (first, second) tail)

//а это сам интерпретатор, такие дела, ага
let rec interpretator (grammar : Grammar) (tape : Tape) = 
    match grammar with
    | Empty -> tape
    | Cons(rule, grtl) ->
        interpretator grtl (rulecheck rule tape)


let rec reader (grammar : Grammar) = 
    let string = System.Console.ReadLine()
    let first = strtotape string
    match System.Console.ReadLine() with
    | "" -> (grammar, first)
    | second -> reader (grammar.addEnd(Cons((first, strtotape second), Empty))) 

//match reader Empty with
//    | (grammar, tape) ->
//        printfn "%A" <| (interpretator grammar tape)


[<EntryPoint>]
let inter argv = 
    match reader Empty with
    | (grammar, tape) ->
        printfn "%A" <| (interpretator grammar tape)
    let rk = System.Console.ReadKey(true)
    0