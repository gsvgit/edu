module Reader

let rule =
    do printfn "%s" "Выберете откуда читать правила\nИз консоли: 1\nИз файла: 2\n"
    match System.Console.ReadLine() with
    |"1" ->
        Rules.console
    |"2" ->
        do printfn "%s" "Укажите путь к файлу:\n"
        Rules.file (System.Console.ReadLine())

let tape =
    do printfn "%s" "Выберете откуда читать ленту\nИз консоли: 1\nИз файла: 2\n"
    match System.Console.ReadLine() with
    |"1" ->
        Tapes.console
    |"2" ->
        do printfn "%s" "Укажите путь к файлу:\n"
        Tapes.file (System.Console.ReadLine())



