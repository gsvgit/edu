let main x = 
    let x2=x*x
    let x4=x2*x2
    x4+x2*x+x2+x+1
let input = System.Console.ReadLine() |> int
System.Console.WriteLine(main input)