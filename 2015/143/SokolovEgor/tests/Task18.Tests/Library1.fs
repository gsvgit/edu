module Task18.Tests

open Task18
open NUnit.Framework

[<Test>]
let ``Usual`` () =
  let res = main("Str")
  Assert.AreEqual(res, Str('S', Str('t', Str('r', Empty))))

[<Test>]
let ``One`` () =
  let res = main("S")
  Assert.AreEqual(res, Str('S', Empty))

[<Test>]
let ``Zero`` () =
  let res = main("")
  Assert.AreEqual(res, Empty)



