module Task19
open Task15
open Task16

type Tree = 
    | Leaf of int
    | Node of int * MyList<Tree>

let compare el (min, max) = 
            if el < min && el > max
            then (el,el)
            elif el < min && el < max 
            then (el,max)
            elif el > min && el > max
            then (min,el)
            else (min,max)    
let main (tree:Tree) =    
    let rec maxmin_tree tree (tmin,tmax) = 
        match tree with
        | Leaf(el) -> 
            compare el (tmin, tmax)
        | Node(n,list) -> 
            let rec maxmin_list (list:MyList<Tree>) (lmin,lmax) = 
                match list with 
                | Empty -> (lmin,lmax)
                | Cons(tree,list) -> maxmin_tree tree (maxmin_list list (lmin,lmax))
            compare n (maxmin_list list (tmin,tmax))          
    match tree with
    | Leaf (el) -> maxmin_tree tree (el,el)
    | Node (n, list) -> maxmin_tree tree (n,n)






