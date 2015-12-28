module Task26

type Rules = List<string * string>

let rec rulCheck ((orig : string) , (rev : string)) (tape: string) =
    let i = tape.IndexOf(orig)
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
    | hd :: tl -> interpretator tl (rulCheck hd tape)



