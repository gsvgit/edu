module Task19.Tests
open NUnit.Framework
open Task15
open Task19
      
[<Test>]                       
let ``max_min Leaf 0 returned (0, 0)`` () =
  let result = max_min <| Leaf 0
  printfn "%A" result
  Assert.AreEqual((0, 0), result)

[<Test>]
let ``max_min(Node(0, (Cons(Leaf 1, Nil)))) returned (1, 0)`` () =
  let result = max_min <| Node(0, Cons(Leaf 1, Nil))
  printfn "%A" result
  Assert.AreEqual((1, 0), result)

[<Test>]
let ``max_min Node(Leaf ...) returned (42, -10)`` () =
  let result = max_min <| Node (-10, Cons((Leaf 1), Cons(Node(42, Nil), Nil)))
  printfn "%A" result
  Assert.AreEqual((42, -10), result)
