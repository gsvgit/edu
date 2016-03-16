module TaskA

let rec fib n f1 f2 i =
  if n > 0 then
    if i - n = 0 then f1 + f2
    else fib n (f1 + f2) f1 (i + 1)
  else
    if i + n = 0 then f2 - f1
    else fib n (f2 - f1) f1 (i + 1)

let main n =
  match n with
  | 0 -> 0
  | 1 | -1 -> 1
  | _ -> fib n 0 1 1
