module Task32.Tests

open NUnit.Framework
open Task32
open Task30
open Task15

[<Test>]
let ``task8 8`` () =
    let res = task8(1, Cons(8, Empty))
    Assert.AreEqual((1, Cons (1, Cons (2, Empty))), res)

[<Test>]
let ``task8 10`` () =
    let res = task8(1, Cons(0, Cons(1, Empty)))
    Assert.AreEqual((1, Cons (5,Cons (5,Empty))), res)

[<Test>]
let ``task9 8`` () =
    let res = task9(1, Cons(8, Empty))
    Assert.AreEqual((1, Cons (1, Cons (2, Empty))), res)

[<Test>]
let ``task9 10`` () =
    let res = task9(1, Cons(0, Cons(1, Empty)))
    Assert.AreEqual((1, Cons (5,Cons (5,Empty))), res)

[<Test>]
let ``task10 8`` () =
    let res = task10(1, Cons(8, Empty))
    Assert.AreEqual((1, Cons (1, Cons (2, Empty))), res)

[<Test>]
let ``task10 10`` () =
    let res = task10(1, Cons(0, Cons(1, Empty)))
    Assert.AreEqual((1, Cons (5,Cons (5,Empty))), res)

[<Test>]
let ``task11 8`` () =
    let res = task11(1, Cons(8, Empty))
    Assert.AreEqual((1, Cons (1, Cons (2, Empty))), res)

[<Test>]
let ``task11 10`` () =
    let res = task11(1, Cons(0, Cons(1, Empty)))
    Assert.AreEqual((1, Cons (5,Cons (5,Empty))), res)

[<Test>]
let ``task12 8`` () =
    let res = task12(1, Cons(8, Empty))
    Assert.AreEqual((1, Cons (1, Cons (2, Empty))), res)

[<Test>]
let ``atsk12 16`` () =
    let res = task12(1, Cons(6, Cons(1, Empty)))
    Assert.AreEqual((1, Cons (7,Cons (8, Cons(9, Empty)))), res)

[<Test>]
let ``task13 10`` () =
    let res = task13(1, Cons(0, Cons(1, Empty)))
    Assert.AreEqual([|(1, Cons (1,Empty)); (1, Cons (1,Empty)); (1, Cons (2,Empty)); (1, Cons (3,Empty)); (1, Cons (5,Empty)); (1, Cons (8,Empty)); (1, Cons (3,Cons (1,Empty))); (1, Cons (1,Cons (2,Empty))); (1, Cons (4,Cons (3,Empty))); (1, Cons (5,Cons (5,Empty)))|], res)
