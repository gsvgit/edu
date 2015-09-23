module Task4

let main (inArray: int array) (num: int) = 
  let len = Array.length inArray - 1
  let mutable index_2 = 0 
  for index in 0..len do
    if inArray.[index] <= num
     then 
      inArray.[index_2] <- index
      index_2 <- index_2 + 1
  let outArray: int array = Array.sub inArray 0 (index_2)
  outArray