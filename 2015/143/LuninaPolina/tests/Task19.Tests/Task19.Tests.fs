module Task19.Tests
open Task19
open Task15
open NUnit.Framework


[<Test>]
let ``main return (0,0)`` () = 
    let res = main (Leaf 0)
    Assert.AreEqual((0,0), res)

[<Test>]
let ``main return (1,5)`` () = 
    let res = main (Node (1,(Cons (Leaf 2,Cons (Leaf 3,Cons (Leaf 4,Empty))))))
    Assert.AreEqual((1,4), res)

[<Test>]
let ``main return (-30,100)`` () = 
    let res = main (Node (-10,Cons (Node (8,Cons (Node (-30,Cons (Leaf 3,Empty)),Cons(Leaf 0, Cons(Leaf 5,Empty)))), Cons(Leaf 100,Empty))))
    Assert.AreEqual((-30,100), res)