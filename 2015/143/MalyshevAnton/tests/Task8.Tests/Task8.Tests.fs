﻿module Task8.Tests

open Task8
open NUnit.Framework

[<Test>]
let ``main 0 returns 0`` () =
  let result = main 0
  Assert.AreEqual(0, result)

[<Test>]
let ``main 2 returns 1`` () =
  let result = main 2
  Assert.AreEqual(1, result)

[<Test>]
let ``main 8 returns 21`` () =
  let result = main 8
  Assert.AreEqual(21, result)