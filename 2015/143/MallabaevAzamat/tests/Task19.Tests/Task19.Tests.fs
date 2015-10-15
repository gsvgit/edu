module Task19.Tests
open NUnit.Framework
open Task15
open Task19
      
[<Test>]                       
let ``max_min Leaf 0 returned Ok(0, 0)`` () =
  let result = max_min <| Leaf 0
  printfn "%A" result
  Assert.AreEqual(Ok(0, 0), result)

[<Test>]
let ``max_min (Node(0, (Cons(Leaf 1, Cons(Leaf 10, Nil)))))) returned Ok(1, 1)`` () =
  let result = max_min <| (Node(0, (Cons(Leaf 1, Cons(Leaf 10, Nil)))))
  printfn "%A" result
  Assert.AreEqual(Ok(10, 1), result)

[<Test>]
let ``max_min (Node (-10, Cons (Node (42, Nil), Nil))) returned Fail`` () =
  let result: Result<int * int> = max_min <| Node (-10, Cons (Node (42, Nil), Nil))
  printfn "%A" result
  Assert.AreEqual(Result<int * int>.Fail, result)
