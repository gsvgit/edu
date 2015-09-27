module Task5  

let main (inArray:array<int>) (lowBound:int) (highBound:int) = 
    
    (*
    let genRandomNumbers count =
        let rnd = System.Random()
        Array.init count (fun _ -> rnd.Next (1, 15)) 

    let inArray = genRandomNumbers 10
    printfn "%A" inArray

    printfn "lowBound = "
    let num1 = System.Console.ReadLine()
    let lowBound = int num1

    printfn "highBound  = "
    let num2 = System.Console.ReadLine()
    let highBound = int num2 
    *)
   
    let mutable L = []

    for i in 0..inArray.Length - 1 do
        if (inArray.[i] < lowBound) || (inArray.[i] > highBound) then 
            L <- i :: L
    let indL = L
    let outArray = [|for i in List.rev(indL) -> i|] 
    outArray