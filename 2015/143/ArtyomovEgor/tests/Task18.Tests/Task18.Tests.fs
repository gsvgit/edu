module Task18.Tests

open Task15
open Task17
open Task18
open NUnit.Framework

[<Test>]
let ``toMyString "123"`` () =
  let res = toMyString("123")
  Assert.AreEqual(res, Cons('1', Cons('2', Cons('3', Empty))))

[<Test>]
let ``toMyString "F"`` () =
  let res = toMyString("F")
  Assert.AreEqual(res, Cons('F', Empty))

[<Test>]
let ``toMyString Space`` () =
  let res = toMyString(" ")
  Assert.AreEqual(res, Cons(' ', Empty))