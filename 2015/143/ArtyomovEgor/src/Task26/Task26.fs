module Task26

open Task15

let rec getString (rules : Task15.MyList<MyList<char> * MyList<char>>) =
    let tape: MyList<'a> = Empty
    let rec getStr (tape : MyList<char>) (str : string) i =
        if i <= str.Length
        then getStr (tape.add(str.[str.Length - i])) str (i + 1)
        else tape

    let string = System.Console.ReadLine()
    let line1 = getStr tape string 1
    match System.Console.ReadLine() with
    | "" -> (rules, line1)
    | newStr -> getString (rules.addEnd(Cons((line1, getStr tape newStr 1), Empty))) 


let rec merge (a : MyList<char>) (b : MyList<char>) =
    match a with
    | Empty -> b
    | Cons(hd, tl) -> Cons(hd, merge tl b)


let rec part (a : MyList<char>) (len : int) =
    if len > 0
    then
        match a with
        | Empty -> Empty
        | Cons(hd, tl) -> part tl (len - 1)
    else
        a


let rec matchRules ( (line1 : MyList<char>), (line2 : MyList<char>) ) (tape : MyList<char>) =
    let rec matchPattern (pattern : MyList<char>) (tape : MyList<char>) = 
        match pattern, tape with
        | Empty, stg -> true
        | Cons(hd1, tl1), Cons(hd2, tl2) ->
            if hd1 = hd2
            then matchPattern tl1 tl2
            else false
        | stg, Empty -> false

    match tape with
    | Empty -> Empty
    | Cons(ch, tail) ->
        if matchPattern line1 tape
        then
            merge line2 (matchRules (line1, line2) (part tape (line1.length())))
        else
            merge (Cons(ch, Empty) ) (matchRules (line1, line2) tail)

let rec main (rules : Task15.MyList<MyList<char> * MyList<char>>) (tape : MyList<char>) = 
    match rules with
    | Empty -> tape
    | Cons(rule, stg) ->
        main stg (matchRules rule tape)

[<EntryPoint>]
let inter argv = 
    match getString Empty with
    | (rules, tape) ->
        printfn "%A" <| main rules tape
    let stay = System.Console.ReadKey(true)
    0