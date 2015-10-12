module Task10.Tests

open Task10
open NUnit.Framework

[<Test>]
let ``main 1 return 1`` () =
  let res = fibN 1
  Assert.AreEqual(1, res)

[<Test>]
let ``main 6 return 8`` () =
  let res = fibN 6
  Assert.AreEqual(8, res)

[<Test>]
let ``main 20 return 6765`` () =
  let res = fibN 20
  Assert.AreEqual(6765, res)