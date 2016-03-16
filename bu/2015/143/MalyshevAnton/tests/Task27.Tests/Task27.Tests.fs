module Task27.Tests

open Task27
open NUnit.Framework

[<Test>]
let ``0.5`` () =
    let result = main 0.5
    printfn "%A" result
    Assert.AreEqual("0011111111100000000000000000000000000000000000000000000000000000", result)

[<Test>]
let ``0`` () =
    let result = main 0.0
    printfn "%A" result
    Assert.AreEqual("0000000000000000000000000000000000000000000000000000000000000000", result)

[<Test>]
let ``-2.5`` () =
    let result = main -2.5
    printfn "%A" result 
    Assert.AreEqual("1100000000000100000000000000000000000000000000000000000000000000", result)