module Task31.Tests

open Task31
open Task30
open Task15
open NUnit.Framework

[<Test>]
let ``0 * 231 = 0`` () = 
    let res = mult (1, Cons(0, Empty)) (1, Cons(1, Cons(3, Cons(2, Empty))))
    Assert.AreEqual((1, Cons(0, Empty)), res)

[<Test>]
let ``-3 * 54 = -162`` () = 
    let res = mult (-1, Cons(3, Empty)) (1, Cons(4, Cons(5, Empty)))
    Assert.AreEqual((-1, Cons(2, Cons(6, Cons(1, Empty)))), res)

[<Test>]
let ``66 * 66 = 4356`` () = 
    let res = mult (1, Cons(6, Cons(6, Empty))) (1, Cons(6, Cons(6, Empty)))
    Assert.AreEqual((1, Cons(6, Cons(5, Cons(3, Cons(4, Empty))))), res)

[<Test>]
let ``1 * 1 = 1`` () = 
    let res = mult (1, Cons(1, Empty)) (1, Cons(1, Empty))
    Assert.AreEqual((1, Cons(1, Empty)), res)
