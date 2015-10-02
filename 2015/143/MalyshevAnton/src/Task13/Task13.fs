module Task13

let rec fib fib_n1 fib_n2 k j =
  if j = k
  then fib_n1
  else fib (fib_n1 + fib_n2) fib_n1 k (j + 1)

let f k =
  if k < 2 then k else
    fib 1 0 k 1

let main n =
  let outArray: int array = [|for i in 0..n -> (f i) |]
  outArray