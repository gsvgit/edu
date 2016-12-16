module Task26.Tests

open Task26
open NUnit.Framework

[<Test>]
let ``Alphabet: a, b, e| Rules: "aa" -> "e"; "bbb" -> "e"; "ba" -> "abb"; "e" -> "".`` () =
    let result = main [("aa", "e"); ("bbb", "e"); ("ba", "abb"); ("e", "")] "ababa"
    Assert.AreEqual(result, "a")

[<Test>]
let ``Alphabet: a, b, c, d| Rules: "acd" -> ""; "bb" -> "".`` () =
    let result = main [("acd", ""); ("bb", "")] "abbcd"
    Assert.AreEqual(result, "")

[<Test>]
let ``Alphabet: +, *, !| Rules: "+++" -> "*"; "***" -> "!"; "!!!" -> "".`` () =
    let result = main [("+++", "*"); ("***", "!"); ("!!!", "")] "!**+++***"
    Assert.AreEqual(result, "")