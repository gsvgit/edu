module Task29.Tests

open Task29
open NUnit.Framework

[<Test>]
let ``positive max number`` () =
    let result = main 9223372036854775807L
    printfn "%A" result
    Assert.AreEqual("0111111111111111111111111111111111111111111111111111111111111111", result)

[<Test>]
let ``negative min number`` () =
    let result = main -9223372036854775808L
    printfn "%A" result
    Assert.AreEqual("1000000000000000000000000000000000000000000000000000000000000000", result)

[<Test>]
let ``some number`` () =
    let result = main 32L
    printfn "%A" result
    Assert.AreEqual("0000000000000000000000000000000000000000000000000000000000100000", result)