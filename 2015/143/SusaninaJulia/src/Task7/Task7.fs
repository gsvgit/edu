module Task7

let main (inArray:array<int>) i j = 
    
    (*
    let genRandomNumbers count =
            let rnd = System.Random()
            Array.init count (fun _ -> rnd.Next (1, 15)) 

    let mutable inArray = genRandomNumbers 10
    printfn "%A" inArray   

    printfn "i = "
    let num1 = System.Console.ReadLine()
    let i = int num1

    printfn "j = "
    let num2 = System.Console.ReadLine()
    let j =  int num2 
    *)

    inArray.[i] <- inArray.[i] + inArray.[j] 
    inArray.[j] <- inArray.[i] - inArray.[j]
    inArray.[i] <- inArray.[i] - inArray.[j]
    inArray