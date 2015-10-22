module Task15

type MyList<'t> =
    | Empty
    | Cons of 't * MyList<'t>