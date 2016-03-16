module Task19.Tests

open Task19
open Task15
open NUnit.Framework

[<Test>]
let ``Тест сложного дерева`` () =
  let result = main (Node(1000, (Cons(Node(10, Cons(Leaf 15, Empty)), Cons(Leaf -30, Empty)))))
  printfn "%A" result
  Assert.AreEqual((1000, -30), result)

[<Test>]
let ``Тест дерева из двух элементов`` () =
  let result = main (Node(13, Cons(Leaf 13, Empty)))
  printfn "%A" result
  Assert.AreEqual((13, 13), result)

[<Test>]
let ``Тест дерева из одного элемента`` () =
  let result = main (Leaf 5)
  printfn "%A" result
  Assert.AreEqual((5, 5), result)