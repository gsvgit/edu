module Task10

let rec main n =
    let mas = [|1; 1; 2; 3|] 
    if n <= 4 then mas.[n-1]
    else main(n - 1) + main(n - 2)