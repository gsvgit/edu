module Task21

open Task15

//Функция выбора опорного элемента
let rec pivot xs min max =
  match xs with
  | Nil -> min
  | Cons (x, Nil) ->
      if min > x then min
      else if max < x then max
      else x
  | Cons (x, Cons(y, ys)) ->
      if x > y then pivot ys (if y > min then y else min) (if x < max then x else max)
      else pivot ys (if x > min then x else min) (if y < max then y else max)

//Функция соединения списков
let rec merge xs ys =
  match xs with
  | Nil -> ys
  | Cons(x, xn) -> Cons (x, merge xn ys)

//Функция выбора элементов списка, удоволетворяющих условию
let rec where lst f =
  match lst with
  | Nil -> Nil
  | Cons(h, t) ->
      if f h then Cons(h, where t f)
      else where t f   

//Сама сортировка
let rec hoar_sort lst =
  match lst with
  | Cons(a, Cons(b, _)) ->
      let z = pivot lst a b
      merge     (hoar_sort <| where lst (fun it -> it < z))
      <| Cons(z, hoar_sort <| where lst (fun it -> it > z))
  | _ -> lst

let main lst = hoar_sort lst