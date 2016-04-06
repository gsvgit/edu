module Task28.Tests

open Task28
open NUnit.Framework

[<Test>]
let ``positive max number`` () =
    let result = main 2147483647
    printfn "%A" result
    Assert.AreEqual("01111111111111111111111111111111", result)

[<Test>]
let ``negative min number`` () =
    let result = main -2147483648
    printfn "%A" result
    Assert.AreEqual("10000000000000000000000000000000", result)

[<Test>]
let ``some number`` () =
    let result = main 16
    printfn "%A" result
    Assert.AreEqual("00000000000000000000000000010000", result)
