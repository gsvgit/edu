module Task26

type StrList = List<string * string>

//Алфавит: {a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, x, z, 0, 1, (space)}
let rules: StrList = [
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
    
//let rec readrules (rules: StrList) =
//    printfn "%s" "Enter a rule"
//    let old = System.Console.ReadLine()
//    printfn "%s" "->"
//    if old = ""
//    then
//        printfn "%s" "Enter a message"
//        rules
//    else
//        let changed = System.Console.ReadLine()
//        printfn "%s" "To enter a message, enter an empty rule"
//        let newrules: StrList = [(old, changed)] @ (readrules rules)
//        newrules

printfn "%s" "Rules: English (lower case) -> ASCII; Example: (a -> 01100001)"

let rec read (newmessage: string) =
    printfn "%s" "Enter a message, or Enter an empty message to complete"
    let message = System.Console.ReadLine()
    if message <> ""
    then
        printfn "%s" (interpretator rules message)
        read ""
    else
        printfn "%s" "Done!"

[<EntryPoint>]
let main argv = 
    read ""
    let l = System.Console.ReadLine()
    0