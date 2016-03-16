module Task18.Tests

open Task17
open Task18
open NUnit.Framework

[<Test>]
let ``toMyString "abc" returns Cons('a', Cons('b', Cons('c', Empty)))`` () =
    let result = toMyString "abc"
    Assert.AreEqual( MyString.Cons('a', MyString.Cons('b', MyString.Cons('c', MyString.Empty))), result)

[<Test>]
let ``toMyString "5" returns Cons('5', Empty)`` () =
    let result = toMyString "5"
    Assert.AreEqual( MyString.Cons('5', MyString.Empty), result)

[<Test>]
let ``toMyString "" returns Empty`` () =
    let result = toMyString ""
    Assert.AreEqual( MyString.Empty, result)