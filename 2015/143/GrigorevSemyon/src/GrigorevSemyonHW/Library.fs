module GrigorevSemyonHW

let intV = 1
let strV = "s"
let boolV = true
let chV = 'c'

let x = 1 + (int "2")

let ifTest x =
    if x = 3
    then 4
    else 5

let forTest =
    for i in 1..3 do
        printfn "%A" (i + 1)

let g (a:array<_>) =
    a.[1] <- 3 
    Array.length a

let f x =
    x + 3


let funArr =  [|f|]

let main () = 
    let v = System.Console.ReadLine()
    let v1 = int v + 1    
    let r = f v1
    printfn "%A" r
