module Task27.Tests

open Task27
open NUnit.Framework

[<Test>]
let ``Task 27 main 2.5`` () =
    let control = "0100000000000100000000000000000000000000000000000000000000000000"
    let res = main 2.5
    Assert.AreEqual(control, res)

[<Test>]
let ``Task 27 main 512.511`` () =
    let control = "0100000010000000000001000001011010000111001010110000001000001100"
    let res = main 512.511
    Assert.AreEqual(control, res)

[<Test>]
let ``Task 27 main -1`` () =
    let control = "1011111111110000000000000000000000000000000000000000000000000000"
    let res = main -1.0
    Assert.AreEqual(control, res)
