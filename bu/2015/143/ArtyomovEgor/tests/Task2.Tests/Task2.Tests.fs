module Task2.Tests

open Task2
open NUnit.Framework

[<Test>]
let ``main 0 return 1`` () =
  let res = main 0
  Assert.AreEqual(1, res)

[<Test>]
let ``main 1 return 5`` () =
  let res = main 1
  Assert.AreEqual(5, res)

[<Test>]
let ``main 5 return 781`` () =
  let res = main 5
  Assert.AreEqual(781, res)

[<Test>]
let ``main 12 return 22621`` () =
  let res = main 12
  Assert.AreEqual(22621, res)