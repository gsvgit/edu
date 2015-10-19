module Task16.Tests
 
open Task15
open Task16
open NUnit.Framework
 
[<Test>]
let ``main Cons(7, Empty) returns 1`` () =
    let result = main(Cons(7, Empty))
    Assert.AreEqual(1, result)

[<Test>]
let ``main Cons('1', Cons('a', Cons('abc', Empty))) returns 3`` () =
    let result = main(Cons("1", Cons("a", Cons("abc", Empty))))
    Assert.AreEqual(3, result)

[<Test>]
let ``main Empty returns 0`` () =
    let result = main(Empty)
    Assert.AreEqual(0, result)