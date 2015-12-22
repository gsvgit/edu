module Task26

type StrList = List<string * string>

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
    
let rec read (rules: StrList) =
    printfn "%s" "Enter a rule"
    let old = System.Console.ReadLine()
    printfn "%s" "->"
    if old = ""
    then
        printfn "%s" "Enter a message"
        rules
    else
        let changed = System.Console.ReadLine()
        printfn "%s" "To enter a message, enter an empty rule"
        let newrules: StrList = [(old, changed)] @ (read rules)
        newrules

let rules = read []
    
printfn "%s" (interpretator rules (System.Console.ReadLine()))
//let l = System.Console.ReadLine()