module Task34

open Task15
open Task26
open System.IO
open Tapes
open Rules
open Reader

let rec outer (tape : Tape) =
    match tape with
    | Empty -> printfn "%s" "\n"
    | Cons(hd, tl) ->
        printf "%s" (hd |> string)
        outer tl
    
let rec reader (rules : Rules) (case : string) =
    match case with
    | "0" ->
        0
    | "1" ->
        System.Console.Clear()
        printf "%s" "Вывод:\n"
        outer (interpretator rules (Reader.tape))
        printfn "%s" "Выберете что делать дельше\nВыход: 0\nВвести новую ленту: 1\nВвести новые правила: 2\n"
        let cs = System.Console.ReadLine()
        reader rules cs
    | "2" ->
        System.Console.Clear()
        let rul = Reader.rule
        printf "%s" "Вывод:\n"
        outer (interpretator rul (Reader.tape))
        printfn "%s" "Выберете что делать дельше\nВыход: 0\nВвести новую ленту: 1\nВвести новые правила: 2\n"
        let cs = System.Console.ReadLine()
        reader rul cs
reader Empty "2"