module TapeReader

open Task15
open Task26
open System.IO

let console (is : string) =
    printfn "%s" "Вводите ленту:\n"
    let str = System.Console.ReadLine()
    Task26.strtotape str

let file (path : string) =
    let strings = File.ReadAllLines(path)
    Task26.strtotape strings.[0]

let sstring (str : string) =
    Task26.strtotape str

//let main =
//    printfn "%s" "Выберете откуда читать ленту\nИз консоли: 1\nИз файла: 2\n"
//    let case = System.Console.ReadLine()
//    match case with
//    |"1" ->
//        Console.tape
//    |"2" ->
//        printfn "%s" "Укажите путь к файлу:\n"
//        File.tape (System.Console.ReadLine())