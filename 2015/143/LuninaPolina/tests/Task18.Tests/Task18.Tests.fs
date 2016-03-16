module Task18.Tests
open Task18
open Task15
open Task16
open Task17
open NUnit.Framework

[<Test>]
let ``toMyString return Cons('1',Cons('2',Cons('3',Empty)))`` () =
  let s = "123"
  let res = toMyString s
  Assert.AreEqual(Cons('1',Cons('2',Cons('3',Empty))), res)

[<Test>]
let ``toMyString return Empty`` () =
  let s = ""
  let res = toMyString s
  Assert.AreEqual(MyString.Empty, res)

[<Test>]
let ``toMyString return Cons('1',Cons('2',Empty))`` () =
  let s = "12"
  let res = toMyString s
  Assert.AreEqual(Cons('1',Cons('2',Empty)), res)

