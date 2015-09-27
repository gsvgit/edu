let mutable mas:array<int> = Array.empty
let bubble (mas:array<int>) =
    let mutable tmp = 0
    for i = (mas.Length - 1) downto 0 do
        for j in 0..i - 1 do
            if mas.[j] > mas.[j + 1] then
                tmp <- mas.[j]
                mas.[j] <- mas.[j+1]
                mas.[j+1] <- tmp
                //mas.[i + 1] <- mas.[i] + mas.[i+1]
                //mas.[i] <- mas.[i + 1] - mas.[i]
                //mas.[i+1] <- mas.[i + 1] - mas.[i]
    mas