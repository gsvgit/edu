module Task4

let main (inArray:array<int>) (num:int) = 
  

(* 
let genRandomNumbers count =
    let rnd = System.Random()
    Array.init count (fun _ -> rnd.Next (1, 15)) // Lambda-expression

let inArray = genRandomNumbers 10
printfn "%A" inArray

let x = System.Console.ReadLine()
let num = int x 
*)


    let mutable L = []

    for i in 0..inArray.Length - 1 do
        if num >= inArray.[i] then 
            L <- i :: L
    let indL = L
    let outArray = [|for i in List.rev(indL) -> i|] 

    printfn "%A" outArray
    outArray