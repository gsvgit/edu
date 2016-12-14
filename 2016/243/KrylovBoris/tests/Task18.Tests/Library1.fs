module Task18.Tests

open Task18
open Task17
open Task15
open NUnit.Framework

[<Test>]
let ``Task 18 toMyString "Hello" = Cons('H', Cons('e', Cons('l', Cons('l', Cons('o', Empty)))))`` () = 
    let res = toMyString "Hello"
    Assert.AreEqual(Cons('H', Cons('e', Cons('l', Cons('l', Cons('o', Empty))))), res)

[<Test>]
let ``Task 18 toMyString "z4x5y" = Cons('z', Cons('4', Cons('x', Cons('5', Cons('y', Empty)))))`` () = 
    let res = toMyString "z4x5y"
    Assert.AreEqual(Cons('z', Cons('4', Cons('x', Cons('5', Cons('y', Empty))))), res)

[<Test>]
let ``Task 18 toMyString "" = Empty`` () = 
    let res = toMyString ""
    Assert.AreEqual(MyString.Empty, res)
