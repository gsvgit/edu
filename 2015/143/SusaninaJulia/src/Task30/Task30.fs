module Task30

open Task15

type Num = char * MyList<int>

let num = System.Console.ReadLine()

let toIntList num = 
    let length = String.length(num)
    let rec toIntL (num : string) (longint : MyList<int>) tmp = 
        if tmp < length 
        then toIntL num (longint.addToTheEnd(num.[tmp] |> int)) (tmp + 1)
        else longint
    toIntL num Empty 0

