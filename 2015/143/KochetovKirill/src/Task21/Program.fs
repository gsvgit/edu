module Task21
open Task15

let main inList : MyList<int> =
    let rec lifter lst =
        match lst with
        | Empty ->
            lst
        | Cons(vl, Empty) ->
            lst
        | Cons(vl, nextLst) ->
            if vl > nextLst.head()
            then
                Cons(nextLst.head(), lifter(Cons(vl, nextLst.tail())))
            else
                Cons(vl, lifter nextLst)
    let rec bubble (list : MyList<int>) s =
        if s < list.length()
        then
            bubble (lifter list) (s + 1)
        else
            list
    bubble inList 0

[<EntryPoint>]
let inter argv = 
    printfn "%A" <| main (Empty.add(1).add(1).add(3).add(1))
    let rk = System.Console.ReadKey(true)
    0