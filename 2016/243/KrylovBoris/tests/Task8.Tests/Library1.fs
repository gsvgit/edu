﻿module Task8.Tests

open Task8
open NUnit.Framework

[<Test>]
let ``Task8 main 0 return 0`` () =
  let res = main 0
  Assert.AreEqual(0, res)

[<Test>]
let ``Task8 main 2 return 1`` () =
  let res = main 2
  Assert.AreEqual(1, res)

[<Test>]
let ``Task8 main 5 return 5`` () =
  let res = main 5
  Assert.AreEqual(5, res)

[<Test>]
let ``Task8 main 10 return 55`` () =
  let res = main 10
  Assert.AreEqual(55, res)