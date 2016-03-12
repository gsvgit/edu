module Task11

let main n = 
    let matrix = array2D [|[|0;1|];[|1;1|]|]
    if n < 2 then n
    else
        for i in 2..n do
            matrix.[0,1] <- matrix.[0,0] + matrix.[0,1]
            matrix.[1,1] <- matrix.[1,1] + matrix.[1,0]
            matrix.[0,0] <- matrix.[0,1] - matrix.[0,0]
            matrix.[1,0] <- matrix.[1,1] - matrix.[1,0]
        matrix.[0,1]