module Task11

let main n =
    if n < 2
    then 
        n
    else 
        let ArrayC = array2D [| [|0 ; 0|] ; [|0 ; 0|] |]
        let ArrayB = array2D [| [|1 ; 1|] ; [|1 ; 1|] |]
        let ArrayA = array2D [| [|1 ; 1|] ; [|1 ; 0|] |]
        for i in 2..n do
            ArrayC.[0 , 0] <- ArrayB.[0 , 0]*ArrayA.[0 , 0] + ArrayB.[0 , 1]*ArrayA.[1 , 0]
            ArrayC.[0 , 1] <- ArrayB.[0 , 0]*ArrayA.[0 , 1] + ArrayB.[0 , 1]*ArrayA.[1 , 1]
            ArrayC.[1 , 0] <- ArrayB.[1 , 0]*ArrayA.[0 , 0] + ArrayB.[1 , 1]*ArrayA.[1 , 0]
            ArrayC.[1 , 1] <- ArrayB.[1 , 0]*ArrayA.[0 , 1] + ArrayB.[1 , 1]*ArrayA.[1 , 1]
            ArrayB.[0 , 0] <- ArrayC.[0 , 0]
            ArrayB.[0 , 1] <- ArrayC.[0 , 1]
            ArrayB.[1 , 0] <- ArrayC.[1 , 0]
            ArrayB.[1 , 1] <- ArrayC.[1 , 1]
        ArrayB.[0 , 1]    