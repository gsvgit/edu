module Task29.Tests

open NUnit.Framework
open Task29

[<Test>]
let ``input minInt64`` () =
  let res = result -9223372036854775808L
  Assert.AreEqual([|1L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L|], res)
[<Test>]
let ``input 1`` () =
  let res = result 1L
  Assert.AreEqual([|0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 1L|], res)
[<Test>]
let ``input maxInt64`` () =
  let res = result 9223372036854775807L
  Assert.AreEqual([|0L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L|], res)