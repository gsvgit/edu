module Task19.Tests

open Task15
open Task17
open Task19
open NUnit.Framework

[<Test>]
let `` main (Node(6, Cons(Leaf 1, Cons(Leaf 2, Empty)))) return (3, 1) `` () =
  let res = main (Node(3, Cons(Leaf 1, Cons(Leaf 2, Empty))))
  Assert.AreEqual((3, 1), res)

[<Test>]
let `` main (Node(2, Cons(Leaf 1, Empty))) return (2, 1) `` () =
  let res = main (Node(2, Cons(Leaf 1, Empty)))
  Assert.AreEqual((2, 1), res)

[<Test>]
let `` main (Node(1, Cons(Node(2, Cons(Leaf 3, Empty)), Empty))) return (2, 1) `` () =
  let res = main (Node(1, Cons(Node(2, Cons(Leaf 3, Empty)), Empty)))
  Assert.AreEqual((3, 1), res)
  
[<Test>]
let `` main (Node(1, Cons(Leaf 2, Cons(Node(3, Cons(Node(4, Cons(Leaf 5, Empty)), Empty)), Empty)))) return (5, 1) `` () =
  let res = main (Node(1, Cons(Leaf 2, Cons(Node(3, Cons(Node(4, Cons(Leaf 5, Empty)), Empty)), Empty))))
  Assert.AreEqual((5, 1), res)

[<Test>]
let ``main (Node(6, Cons(Node(1, Cons(Leaf 7, Cons(Leaf 8, Cons(Leaf 3, Empty)))), Cons(Leaf 2, Cons(Leaf 3, Empty))))) = (2, 8)`` () = 
    let res = main (Node(6, Cons(Node(1, Cons(Leaf 7, Cons(Leaf 8, Cons(Leaf 3, Empty)))), Cons(Leaf 2, Cons(Leaf 3, Empty)))))
    Assert.AreEqual((8, 1), res)