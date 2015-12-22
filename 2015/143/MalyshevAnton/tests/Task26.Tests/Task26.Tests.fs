module Task26.Tests

open Task26
open NUnit.Framework

[<Test>]
let ``Hello -> Bye`` () =
    let result = interpretator [("Hello", "Bye")] "Hello World"
    printfn "%A" result
    Assert.AreEqual(result, "Bye World")

[<Test>]
let ``Empty rules`` () =
    let result = interpretator [] "Hello World"
    printfn "%A" result
    Assert.AreEqual(result, "Hello World")

[<Test>]
let ``Empty message`` () =
    let result = interpretator [("a", "b"); ("c", "d")] ""
    printfn "%A" result
    Assert.AreEqual(result, "")

[<Test>]
let ``rule: something -> empty`` () =
    let result = interpretator [("a", ""); ("c", ""); ("d", "")] "abcdabcdabcdabcd"
    printfn "%A" result
    Assert.AreEqual(result, "bbbb")
