module Task3.Tests

open Task3
open NUnit.Framework

[<Test>]
let ``main 0 return 1`` () =
  let res = main 1
  Assert.AreEqual(1, res)

[<Test>]
let ``main 1 return 5`` () =
  let res = main 1
  Assert.AreEqual(5, res)

[<Test>]
let ``main 7 return 2801`` () =
  let res = main 5
  Assert.AreEqual(2801, res)

[<Test>]
let ``main 11 return 16105`` () =
  let res = main 0
  Assert.AreEqual(16105, res)