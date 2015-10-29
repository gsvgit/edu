module Task12

let input = System.Console.ReadLine() |> int

let mult (a:int[,]) (b:int[,]) =
    let a00 = a.[0, 0] * b.[0, 0] + a.[0, 1] * b.[1, 0]
    let a01 = a.[0, 0] * b.[0, 1] + a.[0, 1] * b.[1, 1]
    let a10 = a.[1, 0] * b.[0, 0] + a.[1, 1] * b.[1, 0]
    let a11 = a.[1, 0] * b.[0, 1] + a.[1, 1] * b.[1, 1]
    
    array2D [ [ a00; a01 ]; [ a10; a11 ] ]

let rec pow n arr =
    if n = 1
    then
        arr
    elif n % 2 = 0
        then
            let mlt = pow (n / 2) arr
            mult mlt mlt

        else
            let mlt = pow ((n - 1) / 2) arr
            mult arr (mult mlt mlt)

let main n =
    let array1 = array2D [ [ 1; 1 ]; [ 1; 0 ] ]
    let output = pow n array1
    output.[0, 1]

[<EntryPoint>]
let entry args =
    printfn "%d" (main input)
    0