module Task30.Tests

open NUnit.Framework
open Task30
open Task15

[<Test>]
let ``test 829 + 314`` () =
    let res = sum (1, Cons(8, Cons(2, Cons(9, Empty)))) (1, Cons(3, Cons(1, Cons(4, Empty))))
    Assert.AreEqual((1, Cons (1, Cons (1, Cons (4, Cons (3, Empty))))), res)

[<Test>]
let ``test 314 - 257`` () =
    let res = sum (-1, Cons(2, Cons(5, Cons(7, Empty)))) (1, Cons(3, Cons(1, Cons(4, Empty))))
    Assert.AreEqual((1, Cons (5, Cons (7, Empty))), res)
[<Test>]
let ``test 257 - 314`` () =
    let res = sum (1, Cons(2, Cons(5, Cons(7, Empty)))) (-1, Cons(3, Cons(1, Cons(4, Empty))))
    Assert.AreEqual((-1, Cons (5, Cons (7, Empty))), res)
[<Test>]
let ``test 1 - 1`` () =
    let res = sum (1, Cons(1, Empty)) (-1, Cons(1, Empty))
    Assert.AreEqual((1, Cons (0, Empty)), res)
[<Test>]
let ``test 11 - 10`` () =
    let res = sum (1, Cons(1, Cons(0, Empty))) (-1, Cons(1, Cons(1, Empty)))
    Assert.AreEqual((-1, Cons (1, Empty)), res)