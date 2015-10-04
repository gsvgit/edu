module Task22


type Result<'okType, 'failType> =
| Ok of 'okType
| Fail of 'failType

//Функция выбора опорного элемента
let pivot (arr: 'a array) i j: Result<'a, string> =
  if j - i < 1 then
    Fail("I cannot return pivot, becouse arr size < 0")
  else
    let max = ref arr.[0]
    let min = ref arr.[0]
    for it in i..(j - 1) do
      if !max < arr.[it] then max := arr.[it]
      else if !min > arr.[it] then min := arr.[it]
      else ()

    let pivot = ref !min
    for it in i..(j - 2) do
      if arr.[it] < arr.[it + 1] then
        min := if arr.[it] > !min then arr.[it] else !min
        max := if arr.[it + 1] < !max then arr.[it + 1] else !max
      else
        min := if arr.[it + 1] > !min then arr.[it + 1] else !min
        max := if arr.[it] < !max then arr.[it] else !max
      if !min > !pivot then
        pivot := !min
      else if !max < !pivot then
        pivot := !max
    Ok(!pivot)

let swap (arr: 'a array) i j =
  let buf = arr.[i]
  arr.[i] <- arr.[j]
  arr.[j] <- buf

//Сама сортировка
let rec hoar_sort arr i j =
  match pivot arr i j with
  | Ok(piv) ->
      let iToPiv = ref 0
      for k in i..(j - 1) do
        if arr.[k] < piv then
          swap arr !iToPiv k
          iToPiv := !iToPiv + 1
        else ()
      hoar_sort (hoar_sort arr i !iToPiv) !iToPiv j
  | _ -> arr

let main arr = hoar_sort arr 0 arr.Length