module Task19.Tests

open Task19
open Task15
open NUnit.Framework

[<Test>]
let ``Task 19 main Leaf 45 = (45, 45)`` () = 
    let res = main (Leaf 45)
    Assert.AreEqual((45, 45), res)

[<Test>]
let ``Task 19 main (Node(4, Cons(Leaf 89, Leaf -4))  = (89, -5)`` () = 
    let res = main (Node(4, Cons(Leaf 89, Cons(Leaf -5, Empty))))
    Assert.AreEqual((-5, 89), res)

[<Test>]
let ``Task 19 main (Node(4, Cons(Node(1, Cons(Leaf 6, Cons(Leaf -2, Empty))), Cons(Leaf 8, Empty)))) = (-2, 8)`` () = 
    let res = main (Node(4, Cons(Node(1, Cons(Leaf 6, Cons(Leaf -2, Empty))), Cons(Leaf 8, Empty))))
    Assert.AreEqual((-2, 8), res)
