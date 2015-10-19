module Task16.Tests
open Task15
open Task16
open NUnit.Framework

[<Test>]
let ``2 List`` () =
  let res = main(Cons(5,Cons(2, Empty)))
  Assert.AreEqual(res, 2)

[<Test>]
let ``0 List`` () =
  let res = main(Empty)
  Assert.AreEqual(res, 0)

[<Test>]
let ``1 List`` () =
  let res = main(Cons(2, Empty))
  Assert.AreEqual(res, 1)