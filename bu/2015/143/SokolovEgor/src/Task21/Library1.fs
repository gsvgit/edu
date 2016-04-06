module Task21
open Task15
open Task16

let main list = 
    if list = Empty 
    then MyList<int>.Empty
    else
        let length lst = Task16.main lst
        let rec sort list = 
            match list with
            | Empty -> list
            | Cons(head, tail) ->
                match tail with
                | Cons(headOfTail, tail2) ->
                    if head > headOfTail 
                    then
                        Cons(headOfTail, Cons(head, sort tail2))
                    else 
                        Cons(head, sort tail)
                | Empty -> list
        let rec repeat list num =
            if (num < length list) 
            then repeat (sort list) (num + 1)
            else list

        repeat list 0


