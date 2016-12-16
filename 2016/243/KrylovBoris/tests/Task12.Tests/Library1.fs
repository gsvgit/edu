﻿module Task12.Tests

open Task12
open NUnit.Framework

[<Test>]
let ``Task12 main 1 return 1`` () =
    let res = main 1
    Assert.AreEqual(1, res)

[<Test>]
let ``Task12 main 5 return 8`` () =
    let res = main 5
    Assert.AreEqual(8, res)

[<Test>]
let ``Task12 main 10 return 55`` () =
    let res = main 10
    Assert.AreEqual(89, res)

[<Test>]
let ``Task12 main -9 Test failure`` () =
    let res = main -9
    Assert.AreEqual(-55, res)