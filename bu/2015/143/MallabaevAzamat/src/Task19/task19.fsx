//Представлен в таком виде, в связи, с проблемами полноценной сборки

type MyList<'a> =
    | Empty
    | Smth of 'a * MyList<'a>

type Tree<'a> =
    | L of 'a
    | N of 'a * MyList<Tree<'a>>

type Opt<'a> =
    | Sth of 'a
    | Nth

let max f s = if f > s then f else s
let min f s = if f < s then f else s

let rec maxMin f s =
  match f, s with
  | Sth (f1, f2), Sth (s1, s2) -> Sth ((max f1 s1), (min f2 s2))
  | Nth, x | x, Nth -> x

let rec main tree =
    match tree with
    | L x -> Sth (x, x)
    | N (_, Empty) -> Nth
    | N (a, Smth (x, xs)) -> maxMin (main x) (main (N (a, xs)))

//Tests:
printf "main (L 1) must returns %A and returns %A\n" (Sth (1, 1)) (main (L 1))

printf "main (N (1, Empty)) must returns %A and returns %A\n" Nth (main (N (1, Empty)))

printf "main (N (1, Smth ((L 2), (Smth ((L 1), Empty))))) must returns %A and returns %A\n" (Sth (2, 1)) (main (N (1, Smth ((L 2), (Smth ((L 1), Empty))))))
