module Task18.Tests

open Task15
open Task17
open Task18
open NUnit.Framework

[<Test>]
let ``Usual`` () =
  let res = main("Str")
  Assert.AreEqual(res, Cons('S', Cons('t', Cons('r', Empty))))

[<Test>]
let ``One`` () =
  let res = main("S")
  Assert.AreEqual(res, Cons('S', Empty))

[<Test>]
let ``Zero`` () =
  let res = main("")
  Assert.AreEqual(res, Empty)



