module Task10

let rec fibN n =
    let mas = [|1; 1; 2; 3|] 
    if n <= 4 then mas.[n-1]
    else fibN(n - 1) + fibN(n - 2)