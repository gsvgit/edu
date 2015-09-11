module Task3.Tests

open Task3
open NUnit.Framework

[<Test>]
let ``main return 5`` () =
  let res = main 1
  Assert.AreEqual(5, res)

[<Test>]
let ``main return 781`` () =
  let res = main 5
  Assert.AreEqual(781, res)

[<Test>]
let ``main return 1`` () =
  let res = main 0
  Assert.AreEqual(1, res)

[<Test>]
let ``Zero`` () =
  let res = main -1
  Assert.AreEqual(1, res)
