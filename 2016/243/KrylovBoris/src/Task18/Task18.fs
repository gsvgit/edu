module Task18
open Task15
open Task17

    let toMyString (string: string) =
        let rec mutate (lst:MyString) (str:string) pointer =
            if pointer < 0 
            then
                lst
            else
                let MyStr = Cons(str.[pointer], lst)
                mutate MyStr str (pointer - 1)
        mutate Empty string (string.Length - 1)