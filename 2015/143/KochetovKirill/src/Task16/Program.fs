module Task16
open Task15

let main List =
  let rec len lst s = 
    match lst with
    |Cons(hd, tl) -> len tl (s + 1)
    |Empty -> s
  len List 0

//let s = System.Console.ReadLine()
//
//[<EntryPoint>]
//let inter argv = 
//  printfn "%A" <| main (Cons(1, Cons(2, Empty)))
//  let rk = System.Console.ReadKey(true)
//  0