module Task15

type MyList<'a> =
    | Empty
    | Cons of 'a * MyList<'a>