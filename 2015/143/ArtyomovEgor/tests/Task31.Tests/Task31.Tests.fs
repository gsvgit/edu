module Task31.Tests

open NUnit.Framework
open Task31
open Task30
open Task15

[<Test>]
let ``test 25 * 35`` () =
    let res = mult (1, Cons(2, Cons(5, Empty))) (1, Cons(3, Cons(5, Empty)))
    Assert.AreEqual((1, Cons(8, Cons (7, Cons(5, Empty)))), res)

[<Test>]
let ``test -25 * 35`` () =
    let res = mult (-1, Cons(2, Cons(5, Empty))) (1, Cons(3, Cons(5, Empty)))
    Assert.AreEqual((-1, Cons(8, Cons (7, Cons(5, Empty)))), res)

[<Test>]
let ``test -25 * -35`` () =
    let res = mult (-1, Cons(2, Cons(5, Empty))) (-1, Cons(3, Cons(5, Empty)))
    Assert.AreEqual((1, Cons(8, Cons (7, Cons(5, Empty)))), res)

[<Test>]
let ``test 25 * -35`` () =
    let res = mult (1, Cons(2, Cons(5, Empty))) (-1, Cons(3, Cons(5, Empty)))
    Assert.AreEqual((-1, Cons(8, Cons (7, Cons(5, Empty)))), res)

[<Test>]
let ``test 255 * 35`` () =
    let res = mult (1, Cons(2, Cons(5, Cons(5, Empty)))) (1, Cons(3, Cons(5, Empty)))
    Assert.AreEqual((1, Cons(8, Cons (9, Cons(2, Cons(5, Empty))))), res)

[<Test>]
let ``test 255 * 355`` () =
    let res = mult (1, Cons(2, Cons(5, Cons(5, Empty)))) (1, Cons(3, Cons(5, Cons(5, Empty))))
    Assert.AreEqual((1, Cons(9, Cons (0, Cons(5, Cons(2, Cons(5, Empty)))))), res)

[<Test>]
let ``test 2557 * 355`` () =
    let res = mult (1, Cons(2, Cons(5, Cons(5, Cons(7, Empty))))) (1, Cons(3, Cons(5, Cons(5, Empty))))
    Assert.AreEqual((1, Cons(9, Cons (0, Cons(7, Cons(7, Cons(3, Cons(5, Empty))))))), res)

[<Test>]
let ``test 355 * 2557`` () =
    let res = mult (1, Cons(3, Cons(5, Cons(5, Empty)))) (1, Cons(2, Cons(5, Cons(5, Cons(7, Empty)))))
    Assert.AreEqual((1, Cons(9, Cons (0, Cons(7, Cons(7, Cons(3, Cons(5, Empty))))))), res)