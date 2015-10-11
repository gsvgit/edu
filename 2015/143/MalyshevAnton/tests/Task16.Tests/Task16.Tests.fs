module Task16.Tests

open Task16
open NUnit.Framework

[<Test>]
let ``main Empty returns 0`` () =
    let result = main(Empty)
    Assert.AreEqual(0, result)

[<Test>]
let ``main Cons(7, Empty) returns 1`` () =
    let result = main(Cons(7, Empty))
    Assert.AreEqual(1, result)

[<Test>]
let ``main Cons('1', Cons('a', Empty)) returns 2`` () =
    let result = main(Cons('1', Cons('a', Empty)))
    Assert.AreEqual(2, result)