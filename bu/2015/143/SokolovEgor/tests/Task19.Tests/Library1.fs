module Task19.Tests

open NUnit.Framework
open Task15
open Task19
      
[<Test>]
let ``main of (0) Must return (0, 0)`` () =
  let result = main (Leaf 0)
  printfn "%A" result
  Assert.AreEqual((0, 0), result)

[<Test>]
let ``main of single tree Must return (50, 9)`` () =
  let result = main (Node(50, (Cons(Leaf 9, Cons(Leaf 10, Empty)))))
  printfn "%A" result
  Assert.AreEqual((50, 9), result)

[<Test>]
let ``main of single tree Must return (7, 5)`` () =
  let result = main (Node(5, Cons(Leaf 7, Empty)))
  printfn "%A" result
  Assert.AreEqual((7, 5), result)
