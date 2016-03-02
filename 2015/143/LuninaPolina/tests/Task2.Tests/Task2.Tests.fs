module Task2.Tests
open Task2
open NUnit.Framework

[<Test>]
let ``main return 5`` () =
  let res = main 1
  Assert.AreEqual(5, res)

[<Test>]
let ``main return 1`` () =
  let res = main 0
  Assert.AreEqual(1, res)

[<Test>]
let ``main return 61`` () =
  let res = main -3
  Assert.AreEqual(61, res)