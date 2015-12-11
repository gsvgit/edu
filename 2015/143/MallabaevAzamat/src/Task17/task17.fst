module Task17

type MyList 'a =
    | Empty: MyList 'a
    | Smth: 'a -> MyList 'a -> MyList 'a

type MyString = MyList char