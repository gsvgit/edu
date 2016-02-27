module TaskD

let main n =
  if n = 0 then [|0|]
  else if n = 1 || n = -1 then [|0; 1|]
  else if n > 0 then
    let fib = [|for _ in 0..n -> 0|]
    fib.[0] <- 0
    fib.[1] <- 1
    for i in 2..n do
      fib.[i] <- fib.[i - 1] + fib.[i - 2]   
    fib
  else
    let fib = [|for _ in 0..-n -> 0|]
    fib.[0] <- 0
    fib.[1] <- 1
    for i in 2..-n do
      fib.[i] <- fib.[i - 2] - fib.[i - 1]   
    fib