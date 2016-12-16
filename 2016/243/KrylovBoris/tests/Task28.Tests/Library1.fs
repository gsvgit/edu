module Task28.Tests

open Task28
open NUnit.Framework

[<Test>]
let ``Task 28 main 2 `` () =
    let control = "00000000000000000000000000000010"
    let res = main 2
    Assert.AreEqual(control, res)

[<Test>]
let ``Task 28 main 512 `` () =
    let control = "00000000000000000000001000000000"
    let res = main 512
    Assert.AreEqual(control, res)

[<Test>]
let ``Task 28 main -1 `` () =
    let control = "11111111111111111111111111111111"
    let res = main -1
    Assert.AreEqual(control, res)