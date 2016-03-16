module Task12.Tests
open Task12
open NUnit.Framework

[<Test>]
let ``main return 55`` () =
  let res = main 10
  Assert.AreEqual(55, res)

[<Test>]
let ``main return 13`` () =
  let res = main 7
  Assert.AreEqual(13, res)

[<Test>]
let ``main return 21`` () =
  let res = main 8
  Assert.AreEqual(21, res)
