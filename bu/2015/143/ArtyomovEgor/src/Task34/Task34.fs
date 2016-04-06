module Task26

type Rules = List<string * string>

let rec interpreter (rules: Rules) (tape: string) =
    let rec getRule ((inner: string), (changed: string)) (tape: string) =
        let i = tape.IndexOf inner
        let innerLenght = String.length inner
        let tapeLenght = String.length tape
        if i < 0
        then
            tape
        else
            let newTape = tape.[0..i - 1] + changed + tape.[i + innerLenght..tapeLenght - 1]
            getRule (inner, changed) newTape
    match rules with
    | [] -> tape
    | hd :: tl ->
        interpreter tl (getRule hd tape)


let rec consoleInputRules (rules: Rules) =
        printfn "%s" "Enter the rule"
        let inner = System.Console.ReadLine()
        printf "%s" " -> "
        if inner = ""
        then
            printfn "%s" "Enter the string"
            rules
        else
            let changed = System.Console.ReadLine()
            printfn "%s" "Press enter if you're done with rules"
            let listOfRules: Rules = List.append [(inner, changed)]  (consoleInputRules rules)
            listOfRules

let fileInputRules rules =
        printfn "%s" "Enter rules file path"
        let rules = System.Console.ReadLine()
        let file = System.IO.File.ReadAllLines(rules)
        let toSList (chang : string []) =
            let mutable rules = []
            let len = chang.GetLength 0 
            for i in 0..len - 1 do
                let tmp = chang.[i]
                let elementLenght = String.length(tmp)
                let i = tmp.IndexOf(" -> ")
                let inner = tmp.[0..i - 1]
                let changed = tmp.[i + 4..elementLenght - 1]
                rules <- rules @ [(inner, changed)]
            rules
        toSList file

let rec consoleInputStr rules (newmessage: string) =
        printfn "%s" "Enter string"
        let str = System.Console.ReadLine()
        if str <> ""
        then
            printfn "%s" (interpreter rules str)
            consoleInputStr rules ""
        else
            printfn "%s" "End"

let fileInputStr rules =
        printfn "%s" "Enter string file path"
        let strings = System.Console.ReadLine()
        let file = System.IO.File.ReadAllLines(strings)
        printfn "%s" "Where to save result? Press enter to print result"
        let resultPath = System.Console.ReadLine()
        if resultPath = ""
        then
            for i in 0..(file.Length - 1) do
                printfn "%A" <| interpreter rules file.[i]
        else
            for i in 0..(file.Length - 1) do
                file.[i] <- interpreter rules file.[i]
            System.IO.File.AppendAllLines(resultPath, file)

printfn "%s" "Where to get rules"
printfn "%s" "1 for console"
printfn "%s" "2 for file"

let inputMethod1 = System.Console.ReadLine() |> string

printfn "%s" "Where to get string"
printfn "%s" "1 for console"
printfn "%s" "2 for file"
 
let inputMethod2 = System.Console.ReadLine() |> string

let choose inputMethod1 inputMethod2 =
    let rulesInpMethod inputMethod1 =
        if inputMethod1 = "1"
        then consoleInputRules []
        elif inputMethod1 = "2"
        then fileInputRules ""
        else consoleInputRules []
 
    let strInpMethod messagechoice =
        if messagechoice = "1"
        then consoleInputStr (rulesInpMethod inputMethod1) ""
        elif messagechoice = "2"
        then fileInputStr (rulesInpMethod inputMethod1)
        else consoleInputStr (rulesInpMethod inputMethod1) ""

    strInpMethod inputMethod2


[<EntryPoint>]
let main argv = 
    choose inputMethod1 inputMethod2
    let s = System.Console.ReadLine()
    0