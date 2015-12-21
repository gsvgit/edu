module Task19

open Task15

type Tree = 
    | Leaf of int
    | Node of int * MyList<Tree>

let main trLst = 
    let init tr = 
        match tr with 
        | Leaf (h) -> (h, h)
        | Node (h, t) -> (h, h)
    
    let rec searchInTree tree (min, max) = 
        match tree with
        | Leaf (hd) -> 
            if hd < min 
            then (hd, max)
            elif hd > max
            then (min, hd)
            else (min, max)
        | Node (hd, tl) -> 
            let rec searchInLeaf (tl : MyList<Tree>) (minL, maxL) = 
                match tl with 
                | Empty -> (minL, maxL)
                | Cons (head, tale) -> searchInTree head (searchInLeaf tale (minL, maxL))
            let (a, b) = searchInLeaf tl (min, max)
            if hd < a 
            then (hd, max)
            elif hd > b
            then (min, hd)
            else searchInLeaf tl (min, max)
    searchInTree trLst (init trLst)


[<EntryPoint>]
let entry args =
    let x = Node(-5, Cons(Node(1, Cons(Leaf 9, Cons(Leaf 11, Cons(Leaf -25, Empty)))), Cons(Leaf 100, Cons(Leaf 888, Empty))))
    printfn "%A" (main x)
    let rk = System.Console.ReadKey(true)
    0