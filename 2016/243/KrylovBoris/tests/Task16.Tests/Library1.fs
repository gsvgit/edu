module Task16.Tests

open Task16
open Task15
open NUnit.Framework

[<Test>]
let ``Task 16 main [2, 9, 4, 6, 4] = 5`` () = 
    let lst = Cons(4, Empty)
    let res = main ((((lst.add 6).add 4). add 9). add 2) 
    Assert.AreEqual(5, res)

[<Test>]
let ``Task 16 main [true, false, true] = 3`` () = 
    let lst = Cons(true, Empty)
    let res = main ((lst.add false).add true)
    Assert.AreEqual(3, res)

[<Test>]
let ``Task 16 main [] = 0`` () = 
    let lst = Empty
    let res = main lst
    Assert.AreEqual(0 ,res)
