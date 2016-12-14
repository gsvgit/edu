module Task26

type RuleList = List<string * string>

let rec parce (word: string, substitute: string) (tape: string) =
    let i = tape.IndexOf(word)
    if i >= 0 
    then
        parce 
            <| (word, substitute)
            <| tape.[0 .. i - 1] + substitute + tape.[i + word.Length .. tape.Length - 1]
    else
        tape

let rec interpretate (r: RuleList) (t: string) =
    match r with
    | [] -> t
    | hd :: tl -> interpretate tl (parce hd t)

let main (r: RuleList) (t: string) =
    let mutable res = t
    let mutable isChangable = true
    while isChangable do
        let mem = res
        res <- interpretate r res
        if mem = res
        then isChangable <- false
    res

