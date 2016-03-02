module Task15

type List<'T> = 
    | Empty 
    | Cons of 'T * List<'T> 
    
    member this.head() =
        match this with
        | Empty -> failwith "Empty"
        | Cons(a,b) -> a 

    member this.tail() =
        match this with
        | Empty -> failwith "Empty"
        | Cons(a,b) -> b
   
    member this.add(el) = 
        match this with
        | Empty -> Cons(el,Empty) //элемент + пустой хвост
        | Cons(a,b)-> Cons(el,this) //элемент + изначальный list в качестве хвоста