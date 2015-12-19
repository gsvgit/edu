module Task21.Tests

open Task15
open Task16
open Task21
open NUnit.Framework

[<Test>]
let ``2 List`` () =
  let result = main(Cons(5,Cons(2, Empty)))
  printfn "%A" result
  Assert.AreEqual(result, Cons(2, Cons(5, Empty)))

[<Test>]
let ``0 List`` () =
  let result = main(Empty)
  printfn "%A" result
  Assert.AreEqual(result, MyList<int>.Empty)

[<Test>]
let ``1 List`` () =
  let result = main(Cons(2, Empty))
  printfn "%A" result
  Assert.AreEqual(result, Cons(2, Empty))

[<Test>]
let ``6 List`` () =
    let result = main(Cons(6, Cons(5, Cons(7, Cons(1, Cons(2, Empty))))))
    printfn "%A" result
    Assert.AreEqual(result, Cons(1, Cons(2, Cons(5, Cons(6, Cons(7, Empty))))))