module Task32.Tests

open NUnit.Framework
open Task32
open Task31
open Task30
open Task15

[<Test>]
let ``fibTask8 7`` () =
    let result = fibTask8 (1, Cons(7, Empty))
    printfn "%A" result
    Assert.AreEqual((1, Cons(1, Cons(3, Empty))), result)

[<Test>]
let ``fibTask9 7`` () =
    let result = fibTask9 (1, Cons(7, Empty))
    printfn "%A" result
    Assert.AreEqual((1, Cons(1, Cons(3, Empty))), result)

[<Test>]
let ``fibTask10 7`` () =
    let result = fibTask10 (1, Cons(7, Empty))
    printfn "%A" result
    Assert.AreEqual((1, Cons(1, Cons(3, Empty))), result)

[<Test>]
let ``fibTask11 7`` () =
    let result = fibTask11 (1, Cons(7, Empty))
    printfn "%A" result
    Assert.AreEqual((1, Cons(1, Cons(3, Empty))), result)

[<Test>]
let ``fibTask12 7`` () =
    let result = fibTask12 (1, Cons(7, Empty))
    printfn "%A" result
    Assert.AreEqual((1, Cons(1, Cons(3, Empty))), result)

[<Test>]
let ``fibTask13 7`` () =
    let result = fibTask13 (1, Cons(7, Empty))
    printfn "%A" result
    Assert.AreEqual([| (1, Cons(0, Empty)); (1, Cons(1, Empty)); (1, Cons(1, Empty)); (1, Cons(2, Empty)); (1, Cons(3, Empty)); (1, Cons(5, Empty)); (1, Cons(8, Empty)); (1, Cons(1, Cons(3, Empty))) |], result)

[<Test>]
let ``toInt`` () =
    let result = toInt (1, Cons(1, Cons(2, Empty)))
    printfn "%A" result
    Assert.AreEqual(12, result)

[<Test>]
let ``fromInt`` () =
    let result = fromInt 12
    printfn "%A" result
    Assert.AreEqual ((1, Cons(1, Cons(2, Empty))), result)

[<Test>]
let ``div2`` () =
    let result = div2 (1, Cons(1, Cons(2, Empty)))
    printfn "%A" result
    Assert.AreEqual ((1, Cons(6, Empty)), result)

[<Test>]
let ``isDiv2`` () =
    let result = isDiv2 (1, Cons(1, Cons(2, Empty)))
    printfn "%A" result
    Assert.AreEqual (0, result)

