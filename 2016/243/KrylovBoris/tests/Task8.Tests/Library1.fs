module Task8.Tests

open Task8
open NUnit.Framework

[<Test>]
let ``Task8 main 1 return 1`` () =
    let res = main 0
    Assert.AreEqual(1, res)

[<Test>]
let ``Task8 main 2 return 2`` () =
    let res = main 2
    Assert.AreEqual(2, res)

[<Test>]
let ``Task8 main 5 return 8`` () =
    let res = main 5
    Assert.AreEqual(8, res)

[<Test>]
let ``Task8 main -9 Test failure`` () =
    let res = main -9
    Assert.AreEqual(-55, res)