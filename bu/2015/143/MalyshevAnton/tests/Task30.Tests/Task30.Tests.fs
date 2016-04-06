module Task30.Tests

open Task30
open NUnit.Framework
open Task15

[<Test>]
let ``123 + 321`` () =
    let result = addition (1, Cons(1, Cons(2, Cons(3, Empty)))) (1, Cons(3, Cons(2, Cons(1, Empty))))
    printfn "%A" result
    Assert.AreEqual((1, Cons(4, Cons (4, Cons (4, Empty)))), result)

[<Test>]
let ``1 - 1`` () =
    let result = addition (1, Cons(1, Empty)) (-1, Cons(1, Empty))
    printfn "%A" result
    Assert.AreEqual((1, Cons(0, Empty)), result)

[<Test>]
let ``0 - 0`` () =
    let result = addition (1, Cons(0, Empty)) (-1, Cons(0, Empty))
    printfn "%A" result
    Assert.AreEqual((1, Cons(0, Empty)), result)

[<Test>]
let ``10 - 0`` () =
    let result = addition (1, Cons(1, Cons(0, Empty))) (-1, Cons(0, Empty))
    printfn "%A" result
    Assert.AreEqual((1, Cons(1, Cons(0, Empty))), result)

[<Test>]
let ``reverse test`` () =
    let result = reverse (Cons(6, Cons(0, Empty))) 
    printfn "%A" result
    Assert.AreEqual(Cons(0, Cons(6, Empty)), result)

[<Test>]
let ``910 - 920`` () =
    let result = addition (1, Cons(9, Cons(1, Cons(0, Empty)))) (-1, Cons(9, Cons(2, Cons(0, Empty))))
    printfn "%A" result
    Assert.AreEqual((-1, Cons(1, Cons(0, Empty))), result)
