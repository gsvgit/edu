module Task15

type List<'a> =
    |Empty
    |Cons of 'a * List<'a>