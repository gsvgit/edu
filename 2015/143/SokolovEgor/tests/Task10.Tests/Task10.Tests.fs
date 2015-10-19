module Task10.Tests

open Task10
open NUnit.Framework

[<Test>]
let ``5 Fib`` () =
  let res = main 5
  Assert.AreEqual(res, 5)

[<Test>]
let ``4 Fib`` () =
  let res = main 4
  Assert.AreEqual(res, 3)

[<Test>]
let ``6 Fib`` () =
  let res = main 6
  Assert.AreEqual(res, 8)

[<Test>]
let ``1 Fib`` () =
  let res = main 1
  Assert.AreEqual(res, 1)
  
[<Test>]
let ``2 Fib`` () =
  let res = main 2
  Assert.AreEqual(res, 1)