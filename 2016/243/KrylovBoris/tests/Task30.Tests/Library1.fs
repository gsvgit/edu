module Task30.Tests
open Task15
open Task30
open NUnit.Framework

[<Test>]
let ``Task30 test 501 + 699 = 1200`` () =
    let res = main (1, Cons(1, Cons(0, Cons(5, Empty)))) (1, Cons(9, Cons(9, Cons(6, Empty))))
    Assert.AreEqual("1200", NumToString(res))

[<Test>]
let ``Task30 test 144 + 144 = 288`` () =
    let res = main (1, Cons(4, Cons(4, Cons(1, Empty)))) (1, Cons(4, Cons(4, Cons(1, Empty))))
    Assert.AreEqual("288", NumToString(res))

[<Test>]
let ``Task30 test 255 + 205 = 460`` () =
    let res = main (1, Cons(5, Cons(5, Cons(2, Empty)))) (1, Cons(5, Cons(0, Cons(2, Empty))))
    Assert.AreEqual("460", NumToString(res))

[<Test>]
let ``Task30 test -25 + 23 = -2`` () =
    let res = main (-1, Cons(5, Cons(2, Empty))) (1, Cons(3, Cons(2, Empty)))
    Assert.AreEqual("-2", NumToString(res))

[<Test>]
let ``Task30 test -23 + 255 = 232`` () =
    let res = main (-1, Cons(3, Cons(2, Empty))) (1, Cons(5, Cons(5, Cons(2, Empty))))
    Assert.AreEqual("232", NumToString(res))

[<Test>]
let ``Task30 test 81 - 196 = -115`` () =
    let res = main (1, Cons(1, Cons(8, Empty))) (-1, Cons(6, Cons(9, Cons(1, Empty))))
    Assert.AreEqual("-115", NumToString(res))

[<Test>]
let ``Task30 test 81 - 81 = 0`` () =
    let res = main (1, Cons(1, Cons(8, Empty))) (-1, Cons(1, Cons(8, Empty)))
    Assert.AreEqual("0", NumToString(res))

[<Test>]
let ``Try to violate the format`` () =
    let res = main (11, Cons(1, Cons(10, Empty))) (-105, Cons(1, Cons(601, Empty)))
    Assert.AreEqual("0", NumToString(res))