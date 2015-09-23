//module Task13
//
//let main n = 
//  let mutable a = ref
//  let mutable b = ref
//  let Fib = [|for i in 1..n do
//                if i = 1 || i = 2 then
//                  yield 1 
//                else 
//                  a <- a + b
//                  b <- a - b 
//                  yield a|]
//  Fib
