module Task11.Tests
open Task11
open NUnit.Framework

[<Test>]
let ``main return 2`` () =
  let res = main 3
  Assert.AreEqual(2, res)

[<Test>]
let ``main return 8`` () =
  let res = main 6
  Assert.AreEqual(8, res)

[<Test>]
let ``main return 21`` () =
  let res = main 8
  Assert.AreEqual(21, res)