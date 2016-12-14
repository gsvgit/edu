module Task2.Tests

open Task2
open NUnit.Framework

[<Test>]
let ``Task2 main 0 return 1`` () =
    let res = main 0
    Assert.AreEqual(1, res)

[<Test>]
let ``Task2 main 1 return 5`` () =
    let res = main 1
    Assert.AreEqual(5, res)

[<Test>]
let ``Task2 main 2 return 31`` () =
    let res = main 2
    Assert.AreEqual(31, res)

[<Test>]
let ``Task2 main 3 return 121`` () =
    let res = main 3
    Assert.AreEqual(121, res)

[<Test>]
let ``Task2 main 4 return 341`` () =
    let res = main 4
    Assert.AreEqual(341, res)

[<Test>]
let ``Task2 main 5 return 781`` () =
    let res = main 5
    Assert.AreEqual(781, res)