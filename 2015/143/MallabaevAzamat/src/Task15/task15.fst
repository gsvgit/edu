module Task15

type MyList 'a =
    | Empty: MyList 'a
    | Smth: 'a -> MyList 'a -> MyList 'a

