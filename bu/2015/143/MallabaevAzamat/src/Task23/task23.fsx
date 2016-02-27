//Не удается легко настроить монстра компиляции для сборки этого модуля

let swap (arr: array<_>) i j =
  let temp = arr.[j]
  arr.[j] <- arr.[i]
  arr.[i] <- temp

let partition (arr: array<_>) l r =
  let pivot = arr.[l]
  swap arr l r

  let mutable j = l
  for i = l to r - 1 do
      if arr.[i] <= pivot then
          swap arr i j
          j <- j + 1
  swap arr j r
  j

let rec qsort arr l r =
  if l < r
  then
    let m = partition arr l r
    (qsort arr l (m - 1))
    (qsort arr (m + 1) r)

let main arr =
  qsort arr 0 (arr.Length - 1)
  arr

//Tests:
printf "main [||] want return [||] and return %A\n" (main [||])
printf "main [|3;2;1|] want return [|1;2;3|] and return %A\n" (main [|3;2;1|])
printf "main [|1;2;3|] want return [|1;2;3|] and return %A\n" (main [|1;2;3|])
