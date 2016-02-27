module Task27.Tests

open NUnit.Framework
open Task27


[<Test>]
let ``input -312.3125`` () =
  let res = arraymain -312.3125
  Assert.AreEqual([|1; 1; 0; 0; 0; 0; 0; 0; 0; 1; 1; 1; 0; 0; 1; 1; 1; 0; 0; 0; 0; 1; 0; 1; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0|], res)

[<Test>]
let ``input 0.88671875`` () =
  let res = arraymain 0.88671875
  Assert.AreEqual([|0; 0; 1; 1; 1; 1; 1; 1; 1; 1; 1; 0; 1; 1; 0; 0; 0; 1; 1; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0|], res)

[<Test>]
let ``input 0`` () =
  let res = arraymain 0.0
  Assert.AreEqual([|for i in 0..63 -> 0|], res)