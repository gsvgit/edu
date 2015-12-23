module Task30.Tests

open Task30
open NUnit.Framework
open Task15

[<Test>]
let ``123 + 321`` () =
    let result = main (1, Cons(1, Cons(2, Cons(3, Empty)))) (1, Cons(3, Cons(2, Cons(1, Empty))))
    printfn "%A" result
    Assert.AreEqual((1, Cons(4, Cons (4, Cons (4, Empty)))), result)

[<Test>]
let ``102 - 2`` () =
    let result = main (-1, Cons(2, Empty)) (1, Cons(1, Cons(0, Cons(2, Empty))))
    printfn "%A" result
    Assert.AreEqual((1, Cons(1, Cons (0, Cons(0, Empty)))), result)

[<Test>]
let ``1 - 1`` () =
    let result = main (1, Cons(1, Empty)) (-1, Cons(1, Empty))
    printfn "%A" result
    Assert.AreEqual((1, Cons(0, Empty)), result)
