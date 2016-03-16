module Task3.Tests
open Task3
open NUnit.Framework

[<Test>]
let ``main return 121`` () =
  let res = main 3
  Assert.AreEqual(121, res)

[<Test>]
let ``main return 1`` () =
  let res = main 0
  Assert.AreEqual(1, res)

[<Test>]
let ``main return 11`` () =
  let res = main -2
  Assert.AreEqual(11, res)
