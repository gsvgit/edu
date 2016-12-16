module Task8

  let rec main n = 
      match n with
      | 0 | 1 -> 1
      | _ -> if n > 1 
             then main(n - 1) + main(n - 2)
             else failwith "Invalid number"