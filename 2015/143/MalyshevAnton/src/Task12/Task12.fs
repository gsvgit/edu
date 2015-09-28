module Task12

let f (ArrayA: int[,]) (ArrayB: int[,])  = 
     let c00 = ArrayA.[0 , 0]*ArrayB.[0 , 0] + ArrayA.[0 , 1]*ArrayB.[1 , 0]
     let c01 = ArrayA.[0 , 0]*ArrayB.[0 , 1] + ArrayA.[0 , 1]*ArrayB.[1 , 1]
     let c10 = ArrayA.[1 , 0]*ArrayB.[0 , 0] + ArrayA.[1 , 1]*ArrayB.[1 , 0]
     let c11 = ArrayA.[1 , 0]*ArrayB.[0 , 1] + ArrayA.[1 , 1]*ArrayB.[1 , 1]
     let ArrayC = array2D [| [|c00 ; c01|] ; [|c10 ; c11|] |]
     ArrayC          
let rec fib k =
  if k < 2
  if k % 2 = 0
  then fib 
let main n =
  if n < 2
  then n
  else 
    if n/2 = 
    for i in 2..n do
