module Task8
  
  let rec main n = 
    if n = 1 || n = 2 
      then 
        1 
      else 
        main (n - 1) + main (n - 2)
