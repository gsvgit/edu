//In this project and in 31 and 32 projects values are written the following way:
// abc = c :: b :: a
module Task30

open Task15

type Num = int * MyList<int>

let isValid ((a, lst): Num) =
    if a < -1 || a > 1 then
        failwith "Invalid sign"
    let rec numCheck (lst: MyList<int>) =
        match lst with
        |Cons(hd, tl) ->
            if hd > 9 || hd < 0 then failwith "Invalid number"
    0 |> ignore
                

let NumToString inNum =
    let rec printer (lst: MyList<int>) =
        match lst with
        |Empty -> ""
        |Cons(hd, tl) -> printer tl + (hd |> string)
    match inNum with
    |a, l ->
        if (a = 1) || (a = 0)
        then printer l
        else "-" + printer l

let rec addition (a: MyList<int>) (b: MyList<int>) (signA: int) (signB: int) (h: int) =
    match a with
    |Empty -> 
        match b with
        |Empty -> 
            if h <> 0
            then Cons(abs(h), Empty)
            else Empty
        |Cons(hdb, tlb) -> 
            let buff = hdb + h
            let h1 = buff / 10
            Cons(buff % 10, addition a tlb signA signB h1) 
    |Cons(hda, tla) ->
        match b with 
        |Empty -> 
            let buff = hda + h
            let h1 = buff / 10
            Cons(buff % 10, addition tla b signA signB h1)    
        |Cons(hdb, tlb) ->
            let buff = hda * signA + hdb * signB + h
            let h1 = buff / 10
            if (buff = 0) && ((tla = Empty) || (tlb = Empty))
            then Empty
            else Cons(abs(buff % 10), addition tla tlb signA signB h1)

let rec compare (a: MyList<int>) (b: MyList<int>) (signA: int) (signB: int) (signRes: int) =
    if length a > length b
    then signA
    elif length a = length b
    then 
        let rec comp (a: MyList<int>) (b: MyList<int>) (key) =
            match a, b with
                |Empty, Empty -> key
                |Cons(hdA, tlA), Cons(hdB, tlB) -> 
                    if hdA = hdB
                    then comp tlA tlB key
                    elif hdA > hdB
                    then comp tlA tlB signA
                    else comp tlA tlB signB
        comp a b 0
    else signB


let main (a: Num) (b: Num) =
    isValid a
    isValid b
    match a, b with
    | (0, Empty), (0, Empty) -> 
        failwith "NaN"
        (0, Cons(0, Empty))
    | (signa, tla), (signb, tlb) ->
    if signa <> signb
    then 
        let signR = compare tla tlb signa signb 0
        if (signR = signb) && (signR = -1)
        then signR, (addition tlb tla signb signa 0)
        else signR, (addition tla tlb signa signb 0)
    else signa, (addition tla tlb signa signb 0)
        




