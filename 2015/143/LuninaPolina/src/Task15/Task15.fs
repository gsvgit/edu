module Task15

type MyList<'T> = 
    | Empty 
    | Cons of 'T * MyList<'T> 
    
    member this.head() =
        match this with
        | Empty -> failwith "Empty"
        | Cons(a,b) -> a 

    member this.tail() =
        match this with
        | Empty -> failwith "Empty"
        | Cons(a,b) -> b
   
    member this.add(el) = 
        Cons(el,this) 