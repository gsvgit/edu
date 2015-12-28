module Task26

type StrList = List<string * string>

printfn "%s" "Choose method of specifying rules:"
printfn "%s" "Enter 'console' for setting rules from console"
printfn "%s" "Enter 'file' for seting rules from file"
printfn "%s" "Enter 'standart' for setting standart rules (English (lower case) -> ASCII; Example: (a -> 01100001))"

let rulechoice = System.Console.ReadLine()

printfn "%s" "Choose method of entering message:"
printfn "%s" "Enter 'console' for entering message from console"
printfn "%s" "Enter 'file' for entering message from file"
printfn "%s" "Enter 'standart' for standart message: 'Hello world'"

let messagechoice = System.Console.ReadLine()

//Алфавит: {a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, x, z, 0, 1, (space)}
let standartRules: StrList = [
    ("a", "01100001")
    ("b", "01100010")
    ("c", "01100011")
    ("d", "01100100")
    ("e", "01100101")
    ("f", "01100110")
    ("g", "01100111")
    ("h", "01101000")
    ("i", "01101001")
    ("j", "01101010")
    ("k", "01101011")
    ("l", "01101100")
    ("m", "01101101")
    ("n", "01101110")
    ("o", "01101111")
    ("p", "01110000")
    ("q", "01110001")
    ("r", "01110010")
    ("s", "01110011")
    ("t", "01110100")
    ("u", "01110101")
    ("v", "01110110")
    ("w", "01110111")
    ("x", "01111000")
    ("y", "01111001")
    ("z", "01111010")
    (" ", "00100000")
    ]

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

let rec interpretator (rules: StrList) (str: string) =
    match rules with
    | [] -> str
    | hd :: tail ->
        interpretator tail (applyRule hd str)

let rec readConsoleRules (rules: StrList) =
    printfn "%s" "Enter a rule"
    let old = System.Console.ReadLine()
    if old = ""
    then
        rules
    else
        printfn "%s" "->"
        let changed = System.Console.ReadLine()
        printfn "%s" "To enter a message, enter an empty rule"
        let newrules: StrList = [(old, changed)] @ (readConsoleRules rules)
        newrules

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
    let filestr = System.IO.File.ReadAllLines(path) 
    let makeRules (str : string []) = 
        let mutable rules = [] 
        let reslength = str.Length 
        for i in 0..(reslength - 1) do 
            let istring = str.[i]
            let istrlen = String.length(istring)
            let i = istring.IndexOf("->")
            let old = istring.[0..(i - 1)]
            let changed = istring.[(i + 2)..(istrlen - 1)]
            rules <- rules @ [(old, changed)]
        rules
    makeRules filestr

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
        then readConsoleRules []
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