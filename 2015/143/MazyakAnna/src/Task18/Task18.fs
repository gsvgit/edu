module Task18

type List<'T> =
    | Empty
    | Cons of 'T*List<'T>

type MyString =
    char List

let rec toMyString (s:string) = 
    let MyS = char s
    MyS

   
