module Task15

type List<'Typex> =
|Empty
|Cons of 'Typex * List<'Typex>
  member this.add(el: 'Typex) = 
    Cons(el, this)
  member this.out() = 
    let rec outer lst = 
      match lst with
      |Cons(hd, tl) -> 
        printfn "%A" <| hd 
        outer tl
      |Empty -> printfn "%A"
    outer this

//[<EntryPoint>]
//let inter argv = 
//  let lst = Cons(1, Cons(2, Cons(3, Empty)))
//  lst.add(4).out()
//  let rk = System.Console.ReadKey(true)
//  0