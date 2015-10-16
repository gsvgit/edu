module Task18.Tests

open Task17
open Task18
open NUnit.Framework

[<Test>]
let ``toMyString "abc" returns String('a', String('b', String('c', Empty)))`` () =
    let result = toMyString "abc"
    Assert.AreEqual( String('a', String('b', String('c', Empty))), result)

[<Test>]
let ``toMyString "5" returns String('5', Empty)`` () =
    let result = toMyString "5"
    Assert.AreEqual( String('5', Empty), result)

[<Test>]
let ``toMyString "" returns Empty`` () =
    let result = toMyString ""
    Assert.AreEqual( Empty, result)