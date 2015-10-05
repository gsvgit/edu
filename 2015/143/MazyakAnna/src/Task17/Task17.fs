module Task17

type List<'T> =
    | Empty
    | Cons of 'T*List<'T>

type MyString =
    char List