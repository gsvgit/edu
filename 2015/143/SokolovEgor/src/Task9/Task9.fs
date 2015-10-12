module Task9


let main n =
    if (n <= 0) then 0 else
        let mutable first = 1
        let mutable second = 1
        let mutable rezult = 0
        for i in 3..n do 
            rezult <- first + second
            first <- second
            second <- rezult
        if n > 2 then rezult else first
        

            