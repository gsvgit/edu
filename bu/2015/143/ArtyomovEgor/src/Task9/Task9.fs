module Task9

let main n =
    let mutable a = 1
    let mutable b = 1

    for i in 1..(n - 1) do
        a <- a + b
        b <- a - b
    b