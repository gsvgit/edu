module Task22
open Task15

let main inList : MyList<int> =
    let rec quickSort list = 
        match list with
        | Empty -> list
        | Cons(head, tail) ->
            (quickSort (tail.filter(fun x -> x < head))
            ).addListToTheEnd(Cons(head, quickSort (tail.filter(fun x -> x = head)))
            ).addListToTheEnd(quickSort (tail.filter(fun x -> x > head)))
    quickSort inList

[<EntryPoint>]
let inter argv = 
    printfn "%A" <| main (Empty.add(3).add(2).add(3).add(4).add(5))
    let rk = System.Console.ReadKey(true)
    0