module Task15

type List<'t> =
    |Empty
    |Cons of 't*List<'t>
