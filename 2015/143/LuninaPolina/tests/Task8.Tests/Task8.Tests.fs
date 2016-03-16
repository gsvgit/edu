module Task8.Tests
open Task8
open NUnit.Framework

[<Test>]
let ``main return 3`` () =
  let res = main 4
  Assert.AreEqual(3, res)

[<Test>]
let ``main return 1`` () =
  let res = main 1
  Assert.AreEqual(1, res)

[<Test>]
let ``main return 55`` () =
  let res = main 10
  Assert.AreEqual(55, res)