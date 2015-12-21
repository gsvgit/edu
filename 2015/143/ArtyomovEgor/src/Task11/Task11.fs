module Task11

let input = System.Console.ReadLine() |> int

let main n =
    let a = array2D [ [1; 1]; [1; 0] ]
    let b = array2D [ [1; 1]; [1; 0] ]

    for i = 1 to n-1 do
        let a00 = a.[0, 0] * b.[0, 0] + a.[0, 1] * b.[1, 0]
        let a01 = a.[0, 0] * b.[0, 1] + a.[0, 1] * b.[1, 1]
        let a10 = a.[1, 0] * b.[0, 0] + a.[1, 1] * b.[1, 0]
        let a11 = a.[1, 0] * b.[0, 1] + a.[1, 1] * b.[1, 1]
        let multarray = array2D [ [a00; a01]; [a10; a11] ]

        a.[0, 0] <- multarray.[0, 0]
        a.[0, 1] <- multarray.[0, 1]
        a.[1, 0] <- multarray.[1, 0]
        a.[1, 1] <- multarray.[1, 1]
    a.[0, 1]

printfn "%d" (main input)