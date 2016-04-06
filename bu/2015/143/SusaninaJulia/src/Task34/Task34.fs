module Task34
open Task26

let defRules = [("1", "0|"); ("|0", "0||"); ("0", "")]

let rec consoleReaderRules (rules: Rules) =
    printfn "%s" "Enter the rule"
    let orig = System.Console.ReadLine()
    if orig = ""
    then
        printfn "%s" "Enter the symbol string"
        rules
    else
        printfn "%s" " -> "
        let rev = System.Console.ReadLine()
        printfn "%s" "To enter a symbol string, press ENTER"
        let listOfRules: Rules = List.append [(orig, rev)]  (consoleReaderRules rules)
        listOfRules

let rec consoleReaderTape rules tape = 
    printfn "%s" "Enter the tape"
    let tape = System.Console.ReadLine()
    if tape = ""
    then printfn "%s" "Press ENTER to end"
    else
        printfn "%s" (interpretator rules tape)
        consoleReaderTape rules ""


let fileReaderTape rules = 
    printfn "%s" "Enter the path to the file"
    let path = System.Console.ReadLine()
    let tape = System.IO.File.ReadAllText(path)
    printfn "%s" (interpretator rules tape)

let fileReaderRules rules = 
    printfn "%s" "Enter the path to the file"
    let path = System.Console.ReadLine()
    let file = System.IO.File.ReadAllLines(path)
    let toStrList (res : string []) = 
        let mutable rules = []
        let reslen = res.GetLength(0)
        for i in 0..reslen - 1 do
            let tmp = res.[i]
            let ellen = String.length(tmp)
            let i = tmp.IndexOf(" -> ")
            let orig = tmp.[0..i - 1]
            let rev = tmp.[i + 4..ellen - 1]
            rules <-  rules @ [(orig, rev)]
        rules
    toStrList file

printfn "%s" "Choose the method to enter the rules :\nConsole\nFile\nString"
let ruleChoise = System.Console.ReadLine()
printfn "%s" "Choose the method to enter the tape :\nConsole\nFile"
let tapeChoise = System.Console.ReadLine()

let choise ruleChoise tapeChoise = 
    let rulchoise ruleChoise =     
        if ruleChoise = "Console"
        then consoleReaderRules []
        elif ruleChoise = "File"
        then fileReaderRules ruleChoise
        else defRules

    let tapchoise (tapeChoise : string) =   
        if tapeChoise = "Console"
        then consoleReaderTape (rulchoise ruleChoise) ""
        else fileReaderTape (rulchoise ruleChoise) 
    tapchoise tapeChoise

[<EntryPoint>]
let main argv = 
    choise ruleChoise tapeChoise
    let rk = System.Console.ReadKey(true)
    0