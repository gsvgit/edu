module Task10.Tests
open Task10
open NUnit.Framework

[<Test>]
let ``main return 5`` () =
  let res = main 5
  Assert.AreEqual(5, res)

[<Test>]
let ``main return 8`` () =
  let res = main 6
  Assert.AreEqual(8, res)

[<Test>]
let ``main return 13`` () =
  let res = main 7
  Assert.AreEqual(13, res)