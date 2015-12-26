module Task31.Tests

open Task31
open NUnit.Framework
open Task15

[<Test>]
let ``123*321`` () =
    let result = multiplication (1, Cons(1, Cons(2, Cons(3, Empty)))) (1, Cons(3, Cons(2, Cons(1, Empty))))
    printfn "%A" result
    Assert.AreEqual((1, Cons(3, Cons(9, Cons(4, Cons(8, Cons(3, Empty)))))), result)

[<Test>]
let ``1*(-1)`` () =
    let result = multiplication (1, Cons(1, Empty)) (-1, Cons(1, Empty))
    printfn "%A" result
    Assert.AreEqual((-1, Cons(1, Empty)), result)

[<Test>]
let ``123*100`` () =
    let result = multiplication (1, Cons(1, Cons(2, Cons(3, Empty)))) (1, Cons(1, Cons(0, Cons(0, Empty))))
    printfn "%A" result
    Assert.AreEqual((1, Cons(1, Cons(2, Cons(3, Cons(0, Cons(0, Empty)))))), result)

[<Test>]
let ``(-11)*0`` () =
    let result = multiplication (-1, Cons(1, Cons(1, Empty))) (1, Cons(0, Empty))
    printfn "%A" result
    Assert.AreEqual((1, Cons(0, Empty)), result)