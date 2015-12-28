module Task26

type StrList = List<string * string>

printfn "%s" "Choose method of specifying rules:"
printfn "%s" "Enter 'console' for setting rules from console"
printfn "%s" "Enter 'file' for seting rules from file"
printfn "%s" "Enter 'standart' for setting standart rules (ab->c;d->f)"

let rulechoice = System.Console.ReadLine()

printfn "%s" "Choose method of entering message:"
printfn "%s" "Enter 'console' for entering message from console"
printfn "%s" "Enter 'file' for entering message from file"
printfn "%s" "Enter 'standart' for standart message: 'Hello world'"

let messagechoice = System.Console.ReadLine()

let standartRules = "ab->c;d->f"

let rec applyRule ((old : string) , (changed : string)) (str: string) =
    let i = str.IndexOf old
    if i >= 0
    then
        let before = str.Substring(0, i)
        let after = str.Substring((i + old.Length), (str.Length - (i + old.Length)))
        let newstr = before + changed + after
        applyRule (old, changed) newstr
    else
        str

let rec interpretator (stringrule: string) (str: string) =

    let remakeStrToRule (str: string) =
    
        let mutable (strList: string []) = [||]
        let rec remToStrList (string: string) =
            if string.Length = 0
            then [||]
            else
                let i = string.IndexOf(";")
                strList <- Array.append [|(string.[0..(i - 1)])|] (remToStrList (string.[(i + 1)..(string.Length - 1)]))
                strList

        let remToRules (strlist: string []) = 
            let mutable rules = [] 
            let reslength = strlist.Length
            for i in 0..(reslength - 1) do 
                let istring = strlist.[i]
                let istrlen = String.length(istring)
                let i = istring.IndexOf("->")
                let old = istring.[0..(i - 1)]
                let changed = istring.[(i + 2)..(istrlen - 1)]
                rules <- rules @ [(old, changed)]
            rules
        remToRules (remToStrList stringrule)

    let rec interpret rule (str: string) =
        match rule with
        | [] -> str
        | hd :: tail -> interpret tail (applyRule hd str)

    interpret (remakeStrToRule stringrule) str

let readConsoleRules (rules: string) =
    printfn "%s" "Enter a rules"
    let rules = System.Console.ReadLine()
    rules

let rec readConsoleMessages rules (newmessage: string) =
    printfn "%s" "Enter a message, or Enter an empty message to complete"
    let message = System.Console.ReadLine()
    if message <> ""
    then
        printfn "%s" (interpretator rules message)
        readConsoleMessages rules ""
    else
        printfn "%s" "Done!"

let readFileRules string = 
    printfn "%s" "Enter the path to the rules" 
    let path = System.Console.ReadLine() 
    let rules = System.IO.File.ReadAllText(path)
    rules

let readFileMessages rules =
    printfn "%s" "Enter the path to the message"
    let path = System.Console.ReadLine()
    let strlist = System.IO.File.ReadAllLines(path)
    printfn "%s" "Enter the path to result message"
    let pathToNewFile = System.Console.ReadLine()
    for i in 0..(strlist.Length - 1) do
        strlist.[i] <- interpretator rules strlist.[i]
    System.IO.File.AppendAllLines(pathToNewFile, strlist)

let reallymain rulechoice messagechoice =

    let ruler rulechoice =
        if rulechoice = "console"
        then readConsoleRules "" 
            elif rulechoice = "standart"
            then standartRules
                elif rulechoice = "file"
                then readFileRules ""
                else standartRules
    
    let messager messagechoice =
        if messagechoice = "console"
        then readConsoleMessages (ruler rulechoice) ""
            elif messagechoice = "file"
            then readFileMessages (ruler rulechoice)
                elif messagechoice = "standart"
                then printfn "%s" (interpretator (ruler rulechoice) "Hello world")
                else printfn "%s" "wrong"

    messager messagechoice

[<EntryPoint>]
let main argv = 
    reallymain rulechoice messagechoice
    let l = System.Console.ReadLine()
    0