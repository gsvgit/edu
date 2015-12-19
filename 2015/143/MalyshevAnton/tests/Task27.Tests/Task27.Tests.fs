module Task27.Tests

open Task27
open NUnit.Framework

[<Test>]
let ``positive number`` () =
    let result = main 12
    printfn "%A" result
    Assert.AreEqual("1100", result)

[<Test>]
let ``negative number`` () =
    let result = main -12
    printfn "%A" result
    Assert.AreEqual("100", result)