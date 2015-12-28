module Chooser

open Task15
open Task26
open TapeReader
open RuleReader

let rule (is : string) =
    printfn "%s" "Выберете откуда читать правила\nИз консоли: 1\nИз файла: 2\n"
    let case = System.Console.ReadLine() |> int
    printfn "%s" "\n"
    match case with
    |1 ->
        RuleReader.console ""
    |2 ->
        printfn "%s" "Укажите путь к файлу:\n"
        RuleReader.file (System.Console.ReadLine())

let tape (is : string) =
    printfn "%s" "Выберете откуда читать ленту\nИз консоли: 1\nИз файла: 2\n"
    let case = System.Console.ReadLine() |> int
    printfn "%s" "\n"
    match case with
    |1 ->
        TapeReader.console ""
    |2 ->
        printfn "%s" "Укажите путь к файлу:\n"
        TapeReader.file (System.Console.ReadLine())
    
