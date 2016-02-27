module Task19.Tests

open Task19
open Task15
open NUnit.Framework

[<Test>]
let ``main Node(6, Cons(Leaf 1, Cons(Leaf 2, Cons(Leaf 3, Empty)))) = (1, 6)`` () = 
    let res = main (Node(6, Cons(Leaf 1, Cons(Leaf 2, Cons(Leaf 3, Empty)))))
    Assert.AreEqual((1, 6), res)

[<Test>]
let ``main Node(-5, Cons(Node(1, Cons(Leaf 9, Cons(Leaf 11, Cons(Leaf -25, Empty)))), Cons(Leaf 100, Cons(Leaf 888, Empty))))`` () = 
    let res = main (Node(-5, Cons(Node(1, Cons(Leaf 9, Cons(Leaf 11, Cons(Leaf -25, Empty)))), Cons(Leaf 100, Cons(Leaf 888, Empty)))))
    Assert.AreEqual((-25 , 888), res)

[<Test>]
let ``main Leaf 0 = (0, 0)`` () = 
    let res = main (Leaf 0)
    Assert.AreEqual((0, 0), res)