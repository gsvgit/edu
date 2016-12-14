module Task29.Tests

open Task29
open NUnit.Framework

[<Test>]
let ``Task 29 main 2 `` () =
    let control = "0000000000000000000000000000000000000000000000000000000000000010"
    let res = main 2L
    Assert.AreEqual(control, res)

[<Test>]
let ``Task 29 main 512 `` () =
    let control = "0000000000000000000000000000000000000000000000000000001000000000"
    let res = main 512L
    Assert.AreEqual(control, res)

[<Test>]
let ``Task 29 main -1 `` () =
    let control = "1111111111111111111111111111111111111111111111111111111111111111"
    let res = main -1L
    Assert.AreEqual(control, res)