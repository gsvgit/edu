module Task19.Tests

open Task19
open Task15
open NUnit.Framework

[<Test>]
let ``main Node(6, Cons(Leaf 1, Cons(Leaf 2, Cons(Leaf 3, Empty)))) = (1, 3)`` () = 
  let res = main (Node(6, Cons(Leaf 1, Cons(Leaf 2, Cons(Leaf 3, Empty)))))
  Assert.AreEqual((1, 3), res)

[<Test>]
let ``main (Node(6, Cons(Node(1, Cons(Leaf 7, Cons(Leaf 8, Cons(Leaf 3, Empty)))), Cons(Leaf 2, Cons(Leaf 3, Empty))))) = (2, 8)`` () = 
  let res = main (Node(6, Cons(Node(1, Cons(Leaf 7, Cons(Leaf 8, Cons(Leaf 3, Empty)))), Cons(Leaf 2, Cons(Leaf 3, Empty)))))
  Assert.AreEqual((2, 8), res)

[<Test>]
let ``main Leaf 0 = (0, 0)`` () = 
  let res = main (Leaf 0)
  Assert.AreEqual((0, 0), res)
