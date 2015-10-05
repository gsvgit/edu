module Task15

type List<'T> =
    | Empty
    | Cons of 'T*List<'T>