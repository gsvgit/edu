module Task21

open Task15
 
let sift (lst : MyList<int>) =
    let mutable lst1 = Empty
    let mutable lst2 = lst
    for i in 1..lst.getLength() - 1 do
        match lst2 with
        | Empty -> Empty |> ignore
        | Cons (hd, tl) ->
            if hd > tl.getHead()
            then lst2 <- lst2.swap()
        lst1 <- lst1.addToTheEnd(lst2.getHead())
        lst2 <- lst2.deleteHead()
    
    lst1 <- lst1.addToTheEnd(lst2.getHead())
    lst1  

let main lst =          
    let rec bubbleSort (lst: MyList<int>) n =
        if n < lst.getLength()
        then bubbleSort (sift lst) (n + 1)
        else lst
    bubbleSort lst 0

[<EntryPoint>]
let entry args =
    let x = Cons(2, Cons(1, Cons(4, Cons(3, Empty))))
    printfn "%A" (main x)
    let rk = System.Console.ReadKey(true)
    0