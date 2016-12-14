module Task12.Tests

open Task12
open NUnit.Framework

[<Test>]
let ``Task12 main 2 return 1`` () =
    let res = main 2
    Assert.AreEqual(1, res)

[<Test>]
let ``Task12 main 5 return 5`` () =
    let res = main 5
    Assert.AreEqual(5, res)

[<Test>]
let ``Task12 main 10 return 55`` () =
    let res = main 10
    Assert.AreEqual(55, res)