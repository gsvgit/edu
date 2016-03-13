module Task9.Tests
open Task9
open NUnit.Framework

[<Test>]
let ``main return 5`` () =
  let res = main 5
  Assert.AreEqual(5, res)

[<Test>]
let ``main return 1`` () =
  let res = main 2
  Assert.AreEqual(1, res)

[<Test>]
let ``main return 89`` () =
  let res = main 11
  Assert.AreEqual(89, res)
