module Task26.Tests

open Task26
open NUnit.Framework

[<Test>]
let ``interpret test`` () =
    let result = interpretator [("ab", "c"); ("d", "f"); ("c", "g")] "abdabdab"
    printfn "%A" result
    Assert.AreEqual(result, "gfgfg")