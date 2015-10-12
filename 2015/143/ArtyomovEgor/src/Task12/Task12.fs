module Task12

let input = System.Console.ReadLine() |> int


let mult (a:int[,]) (b:int[,]) =
    let a00 = a.[0, 0] * b.[0, 0] + a.[0, 1] * b.[1, 0]
    let a01 = a.[0, 0] * b.[0, 1] + a.[0, 1] * b.[1, 1]
    let a10 = a.[1, 0] * b.[0, 0] + a.[1, 1] * b.[1, 0]
    let a11 = a.[1, 0] * b.[0, 1] + a.[1, 1] * b.[1, 1]
    
    let m = array2D [ [a00; a01]; [a10; a11] ]
    m

let rec pow n arr =
//    let y = array2D [ []; [] ]
    if (n = 1) then
        let y = arr
        y
    else
        if (n % 2 = 0) then
            let y = mult (pow (n/2) arr) (pow (n/2) arr)
            y
        else
            let y = mult arr (mult (pow ((n - 1) / 2) arr) (pow ((n - 1)/ 2 ) arr))
            y

let main n =
    let array1 = array2D [ [1; 1]; [1; 0] ]  
    let output = pow n array1
    output.[0, 1]


printfn "%d" (main input)