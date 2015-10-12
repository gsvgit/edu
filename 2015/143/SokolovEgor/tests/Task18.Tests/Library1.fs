module Task18.Tests

open Task15
open Task17
open Task18
open NUnit.Framework

[<Test>]
let ``Usual`` () =
  let res = toMyString("Str")
  Assert.AreEqual(res, Cons('S', Cons('t', Cons('r', Empty))))

[<Test>]
let ``One`` () =
  let res = toMyString("S")
  Assert.AreEqual(res, Cons('S', Empty))

[<Test>]
let ``Space`` () =
  let res = toMyString(" ")
  Assert.AreEqual(res, Cons(' ', Empty))



