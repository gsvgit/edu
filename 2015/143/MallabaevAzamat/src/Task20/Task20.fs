module Task20

let swap (arr: 'a array) i j =
  let buf = arr.[i]
  arr.[i] <- arr.[j]
  arr.[j] <- buf

let bubble_sort (inArr: 'a array) =
  let outArr = Array.copy inArr
  let l = inArr.Length
  for i in 1..l do
    for j in i..l do
      if outArr.[i] > outArr.[j] then
        swap outArr i j
