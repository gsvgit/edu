module Task34

open Task15
open Task26

let rec outer (tape : Tape) =
    match tape with
    | Empty -> printfn "%s" "\n"
    | Cons(hd, tl) ->
        printf "%s" (hd |> string)
        outer tl
    
let rec reader (rules : Rules) (case : int) =
    match case with
    | 0 ->
        0
    | 1 ->
        printfn "%s" "Вывод:\n"
        outer (interpretator rules (Chooser.tape ""))
        printfn "%s" "Выберете что делать дaльше\nВыход: 0\nВвести новую ленту: 1\nВвести новые правила: 2"
        let cs = System.Console.ReadLine() |> int
        reader rules cs
    | 2 ->
        let rul = Chooser.rule ""
        printfn "%s" "Вывод:\n"
        outer (interpretator rul (Chooser.tape ""))
        printfn "%s" "Выберете что делать дaльше\nВыход: 0\nВвести новую ленту: 1\nВвести новые правила: 2"
        let cs = System.Console.ReadLine() |> int
        reader rul cs
reader Empty 2
    
//module Task34
//
//open Task15
//open Task26
//open System.IO
//open TapeReader
//open RuleReader
//
//let rec outer (tape : Tape) =
//    match tape with
//    | Empty -> printfn "%s" "\n"
//    | Cons(hd, tl) ->
//        printf "%s" (hd |> string)
//        outer tl
//    
//let rec reader (rules : Rules) (case : string) =
//    match case with
//    | "0" ->
//        0
//    | "1" ->
//        System.Console.Clear()
//        printf "%s" "Вывод:\n"
//        outer (interpretator rules (Reader.tape))
//        printfn "%s" "Выберете что делать дельше\nВыход: 0\nВвести новую ленту: 1\nВвести новые правила: 2\n"
//        let cs = System.Console.ReadLine()
//        reader rules cs
//    | "2" ->
//        System.Console.Clear()
//        let rul = Reader.rule
//        printf "%s" "Вывод:\n"
//        outer (interpretator rul (Reader.tape))
//        printfn "%s" "Выберете что делать дельше\nВыход: 0\nВвести новую ленту: 1\nВвести новые правила: 2\n"
//        let cs = System.Console.ReadLine()
//        reader rul cs
//reader Empty "2"
//
//let rec main (rules : Rules) (case : int) =
//    if case = 0
//    then
//        0
//    elif case = 1
//    then
//        outer (interpretator rules TapeReader.main)
//        printfn "%s" "Выберете что делать дельше\nВыход: 0\nВвести новую ленту: 1\nВвести новые правила: 2\n"
//        let cs = System.Console.Read()
//        main rules cs
//    else
//        let newrules = RuleReader.main
//        outer (interpretator newrules TapeReader.main)
//        printfn "%s" "Выберете что делать дельше\nВыход: 0\nВвести новую ленту: 1\nВвести новые правила: 2\n"
//        let cs = System.Console.Read()
//        main newrules cs
//main Empty 2