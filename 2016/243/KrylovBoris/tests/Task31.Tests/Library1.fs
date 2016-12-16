module Task31.Tests
open Task15
open Task30
open NUnit.Framework

[<Test>]
let ``Task31 test 501 * 699 = 359999`` () =
    let res = multiply (1, Cons(1, Cons(0, Cons(5, Empty)))) (1, Cons(9, Cons(9, Cons(6, Empty))))
    Assert.AreEqual("350199", NumToString(res))

[<Test>]
let ``Task31 test -144 * -144 = 20736`` () =
    let res = multiply (-1, Cons(4, Cons(4, Cons(1, Empty)))) (-1, Cons(4, Cons(4, Cons(1, Empty))))
    Assert.AreEqual("20736", NumToString(res))

[<Test>]
let ``Task31 test -23 * 255 = -5865`` () =
    let res = multiply (-1, Cons(3, Cons(2, Empty))) (1, Cons(5, Cons(5, Cons(2, Empty))))
    Assert.AreEqual("-5865", NumToString(res))

[<Test>]
let ``Task31 test 81 * 0 = 0`` () =
    let res = multiply (1, Cons(1, Cons(8, Empty))) (0, Cons(0, Empty))
    Assert.AreEqual("0", NumToString(res))