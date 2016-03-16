module Task30.Tests

open NUnit.Framework
open Task30
open Task15

[<Test>]
let ``test 355 + 255`` () =
    let res = sum (1, Cons(3, Cons(5, Cons(5, Empty)))) (1, Cons(2, Cons(5, Cons(5, Empty))))
    Assert.AreEqual((1, Cons (6, Cons (1, Cons (0, Empty)))), res)

[<Test>]
let ``test 255 + 355`` () =
    let res = sum (1, Cons(2, Cons(5, Cons(5, Empty)))) (1, Cons(3, Cons(5, Cons(5, Empty))))
    Assert.AreEqual((1, Cons (6, Cons (1, Cons (0, Empty)))), res)

[<Test>]
let ``test 255 + 255`` () =
    let res = sum (1, Cons(2, Cons(5, Cons(5, Empty)))) (1, Cons(2, Cons(5, Cons(5, Empty))))
    Assert.AreEqual((1, Cons (5, Cons (1, Cons (0, Empty)))), res)

[<Test>]
let ``test -255 + 253`` () =
    let res = sum (-1, Cons(2, Cons(5, Cons(5, Empty)))) (1, Cons(2, Cons(5, Cons(3, Empty))))
    Assert.AreEqual((-1, Cons(2, Empty)), res)

[<Test>]
let ``test -253 + 255`` () =
    let res = sum (-1, Cons(2, Cons(5, Cons(3, Empty)))) (1, Cons(2, Cons(5, Cons(5, Empty))))
    Assert.AreEqual((1, Cons(2, Empty)), res)

[<Test>]
let ``test -255 + 255`` () =
    let res = sum (-1, Cons(2, Cons(5, Cons(5, Empty)))) (1, Cons(2, Cons(5, Cons(5, Empty))))
    Assert.AreEqual((1, Cons (0, Empty)), res)

[<Test>]
let ``test 256 - 254`` () =
    let res = sum (1, Cons(1, Empty)) (-1, Cons(1, Empty))
    Assert.AreEqual((1, Cons (0, Empty)), res)

[<Test>]
let ``test 254 - 256`` () =
    let res = sum (1, Cons(2, Cons(5, Cons(4, Empty)))) (-1, Cons(2, Cons(5, Cons(6, Empty))))
    Assert.AreEqual((-1, Cons (2, Empty)), res)

[<Test>]
let ``test 255 - 255`` () =
    let res = sum (1, Cons(2, Cons(5, Cons(5, Empty)))) (-1, Cons(2, Cons(5, Cons(5, Empty))))
    Assert.AreEqual((1, Cons (0, Empty)), res)

[<Test>]
let ``test -255 - 255`` () =
    let res = sum (-1, Cons(2, Cons(5, Cons(5, Empty)))) (-1, Cons(2, Cons(5, Cons(5, Empty))))
    Assert.AreEqual((-1, Cons (5, Cons (1, Cons (0, Empty)))), res)

[<Test>]
let ``test -256 - 254`` () =
    let res = sum (-1, Cons(2, Cons(5, Cons(6, Empty)))) (-1, Cons(2, Cons(5, Cons(4, Empty))))
    Assert.AreEqual((-1, Cons (5, Cons (1, Cons (0, Empty)))), res)

[<Test>]
let ``test -254 - 256`` () =
    let res = sum (-1, Cons(2, Cons(5, Cons(4, Empty)))) (-1, Cons(2, Cons(5, Cons(6, Empty))))
    Assert.AreEqual((-1, Cons (5, Cons (1, Cons (0, Empty)))), res)


[<Test>]
let ``test 500 - 1`` () =
    let res = sum (1, Cons(5, Cons(0, Cons(0, Empty)))) (-1, Cons(1, Empty))
    Assert.AreEqual((1, Cons (4, Cons(9, Cons(9, Empty)))), res)

[<Test>]
let ``test 500 + 1`` () =
    let res = sum (1, Cons(5, Cons(0, Cons(0, Empty)))) (1, Cons(1, Empty))
    Assert.AreEqual((1, Cons (5, Cons(0, Cons(1, Empty)))), res)
