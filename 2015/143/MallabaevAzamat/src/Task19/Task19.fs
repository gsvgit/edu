module Task19

open Task15

type 'a Tree =
| Node of 'a * 'a TreeList
| Leaf of 'a

and 'a TreeList = 'a Tree List            

let rec fold start f = function
  | Nil -> start
  | Cons(hd, tl) -> fold (f start hd) f tl

let map f = fold Nil <| fun st li -> Cons(f li, st)
let forAll f = fold () <| fun _ li -> f li

let max a b = match a > b with | true -> a | _ -> b
let min a b = match a < b with | true -> a | _ -> b

type Result<'okType> =
| Ok of 'okType
| Fail

let rec max_min = function
  | Node(_, lst) ->
      let rec lstmm st l = l |> fold st (function
        | Fail -> function
          | Node(_, lst) -> lstmm Fail lst
          | Leaf a -> Ok (a, a)
        | Ok((mx, mn)) -> function
          | Node(_, lst) -> lstmm st lst
          | Leaf a -> Ok ((max a mx), min a mn))
      lstmm Fail lst
  | Leaf a -> Ok (a, a)

let rT2Str = function
| Ok (a, b) -> sprintf "Ok : (%s, %s)" (a.ToString()) (b.ToString())
| Fail -> "Fail"

[<EntryPoint>]
let entry args =
  printfn "%s" <| rT2Str (max_min <| Node (1, Cons(Leaf 10, Cons(Leaf 1, Nil))))
  ignore <| System.Console.ReadLine()
  0