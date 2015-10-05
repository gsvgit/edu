//module Task18
//
//open Task17
//open Task15
//
//  let toMyString (str:string) = 
//    let mystr:MyString = Empty
//    for i in 1..str.Length do mystr.add(str.[str.Length-i])
//    mystr  
//
//  [<EntryPoint>]
//  let inter argv = 
//    let str = "adcs345"
//    let lst = toMyString str
//    printfn "%A" lst
//    let rk = System.Console.ReadKey(true)
//    0