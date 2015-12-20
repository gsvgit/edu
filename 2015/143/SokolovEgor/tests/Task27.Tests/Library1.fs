module Task27.Tests

open NUnit.Framework
open Task27

[<Test>]
let ``return , unsorted`` () =
  let res = main -1.0
  Assert.AreEqual(12312, res)