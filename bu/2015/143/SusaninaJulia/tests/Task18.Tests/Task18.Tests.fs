module Task18.Tests

open Task15 
open Task17
open Task18
open NUnit.Framework
 
[<Test>]
let ``toMyString "str" returns Cons('s', Cons('t', Cons('r', Empty)))`` () =
    let result = toMyString "str"
    Assert.AreEqual((Cons('s', Cons('t', Cons('r', Empty)))), result)

[<Test>]
let ``toMyString "13" returns Cons('1', Cons('3', Empty)`` () =
    let result = toMyString "13"
    Assert.AreEqual((Cons('1', Cons('3', Empty))), result)

[<Test>]
let ``toMyString "" returns Empty`` () =
    let result = toMyString ""
    Assert.AreEqual((Empty: MyString), result)