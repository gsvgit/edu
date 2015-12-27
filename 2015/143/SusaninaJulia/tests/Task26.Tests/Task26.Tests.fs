module Task26.Tests

open Task26
open NUnit.Framework

[<Test>]
let ``This algorithm rewrites binary numbers to their unary counterparts`` () =
    let result = interpretator [("1", "0|"); ("|0", "0||"); ("0", "")] "101"
    printfn "%A" result
    Assert.AreEqual(result, "|||||")

[<Test>]
let ``Interpretator without rules`` () =
    let result = interpretator [] "abcd"
    printfn "%A" result
    Assert.AreEqual(result, "abcd")

[<Test>]
let ``Interpretator without tape`` () =
    let result = interpretator [("1", "2"); ("3", "4")] ""
    printfn "%A" result
    Assert.AreEqual(result, "")
