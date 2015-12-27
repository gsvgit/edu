module RuleReader

open Task15
open Task26
open System.IO


let console =
    printf "%s" "Вводите прaвила:\n"
    let rec reader (rules : Rules) = 
        match System.Console.ReadLine() with
        | "" -> rules
        | first ->
            let second = System.Console.ReadLine()
            reader (rules.addListToTheEnd(Cons((Task26.strtotape first, Task26.strtotape second), Empty)))
    reader Empty

let file (path : string) =
    let strings = File.ReadAllLines(path)
    let mutable (rules : Rules) = Empty
    for i in 0..2..(strings.Length - 1) do
        rules <- rules.addListToTheEnd(Cons((Task26.strtotape strings.[i], Task26.strtotape strings.[i + 1]), Empty))
    rules

let sstring (str : string) =
    let mutable is = false
    let mutable (rules : Rules) = Empty
    let mutable (first : Tape) = Empty
    let mutable (second : Tape) = Empty
    for i in 0..(str.Length - 1) do
        if str.[i] = '\n'
        then
            if is
            then
                is <- false
                rules <- rules.addListToTheEnd(Cons((first, second), Empty))
                first <- Empty
                second <- Empty
            else
                is <- true
        else
            if is
            then
                second <- second.addListToTheEnd(Cons(str.[i], Empty))
            else
                first <- first.addListToTheEnd(Cons(str.[i], Empty))
    rules

let main =
    printfn "%s" "Выберете откуда читать правила\nИз консоли: 1\nИз файла: 2\n"
    let case = System.Console.Read()
    if case = 1
    then
        console
    else
        printfn "%s" "Укажите путь к файлу:\n"
        let path = System.Console.ReadLine()
        file path