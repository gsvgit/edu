module Task18.Tests

open Task18
open Task17
open Task15
open NUnit.Framework

[<Test>]
let ``toMyString "abc" = Cons('a', Cons('b', Cons('c', Empty)))`` () = 
  let res = toMyString "abc"
  Assert.AreEqual(Cons('a', Cons('b', Cons('c', Empty))),res)

[<Test>]
let ``toMyString "abc45" = Cons('a', Cons('b', Cons('c', Cons('4', Cons('5', Empty)))))`` () = 
  let res = toMyString "abc45"
  Assert.AreEqual(Cons('a', Cons('b', Cons('c', Cons('4', Cons('5', Empty))))),res)

[<Test>]
let ``toMyString "" = Empty`` () = 
  let res = toMyString ""
  Assert.AreEqual(MyString.Empty, res)
