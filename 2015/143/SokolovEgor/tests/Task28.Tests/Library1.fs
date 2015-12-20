module Task28.Tests

open NUnit.Framework
open Task28

[<Test>]
let ``input -2 147 483 648 output 1 (1) and 31 (0)`` () =
  let res = result -2147483648
  Assert.AreEqual([|1; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0|], res)
[<Test>]
let ``input 0 output 32 (0)`` () =
  let res = result 0
  Assert.AreEqual([for i in 0..31 -> 0], res)
[<Test>]
let ``input 1 output 31 (0) and 1 (1)`` () =
  let res = result 1
  Assert.AreEqual([|0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 1|], res)
[<Test>]
let ``input -1 output 32 (1)`` () =
  let res = result -1
  Assert.AreEqual([for i in 0..31 -> 1], res)