module Task8

  let rec main n = 
      match n with
      | 0 -> 0
      | 1 | 2 -> 1
      | _ -> if n > 1 
             then 
                 main(n - 1) + main(n - 2)
             else
                 main(n + 1) + main(n + 2)