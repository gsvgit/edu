module Tapes

open Task15
open Task26
open System.IO

let console =
    do printfn "%s" "Вводите ленту:\n"
    let str = System.Console.ReadLine()
    Task26.strtotape str
    
let file (path : string) =
    let strings = File.ReadAllLines(path)
    Task26.strtotape strings.[0]

let sstring (str : string) =
    Task26.strtotape str