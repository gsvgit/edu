module Task9

let main n =
  if n = 0 then 0
  else
    let fibN2 = ref 0
    let fibN1 = ref 1
  
    if n > 0 then
      for i in 2..n do
        let fibN = !fibN2 + !fibN1
        fibN2 := !fibN1
        fibN1 := fibN      
    else
      for i in 2..-n do
        let fibN = !fibN2 - !fibN1
        fibN2 := !fibN1
        fibN1 := fibN

    !fibN1