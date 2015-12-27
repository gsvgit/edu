module Task26

type Rules = List<string * string>

let rec rulCheck ((orig : string) , (rev : string)) (tape: string) =
    let i = tape.IndexOf orig
    let orlen = String.length(orig)
    let taplen = String.length(tape)
    if i >= 0
    then
        let revtape = tape.[0..i - 1] + rev + tape.[i + orlen..taplen - 1]
        rulCheck (orig, rev) revtape
    else
        tape

let rec interpretator (rules: Rules) (tape: string) =
    match rules with
    | [] -> tape
    | hd :: tl ->
        interpretator tl (rulCheck hd tape)

let rec consoleReader (rules: Rules) =
    printfn "%s" "Enter the rule"
    let orig = System.Console.ReadLine()
    printfn "%s" " -> "
    if orig = ""
    then
        printfn "%s" "Enter the symbol string"
        rules
    else
        let rev = System.Console.ReadLine()
        printfn "%s" "To enter a symbol string, press ENTER"
        let listOfRules: Rules = List.append [(orig, rev)]  (consoleReader rules)
        listOfRules

let rules = consoleReader []
let tape = System.Console.ReadLine()
printfn "%s" (interpretator rules tape)
