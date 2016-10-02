module Task6

  let main (inArray: array<int>) : array<int> = 
      inArray.[0] <- inArray.[0] ^^^ inArray.[1]
      inArray.[1] <- inArray.[0] ^^^ inArray.[1]
      inArray.[0] <- inArray.[0] ^^^ inArray.[1]
      let outArray = inArray
      outArray