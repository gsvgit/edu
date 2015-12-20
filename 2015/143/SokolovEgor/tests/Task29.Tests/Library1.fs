module Task29.Tests

open NUnit.Framework
open Task29

[<Test>]
let ``input -2 147 483 648 output 1 (1) and 31 (0L)`` () =
  let res = result -2147483648L
  Assert.AreEqual([|1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 1L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L|], res)
[<Test>]
let ``input 0L output 32 (0L)`` () =
  let res = result 0L
  Assert.AreEqual([for i in 0..63 -> 0L], res)
[<Test>]
let ``input 1 output 31 (0L) and 1 (1)`` () =
  let res = result 1L
  Assert.AreEqual([|0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 1L|], res)
[<Test>]
let ``input -1 output 32 (1)`` () =
  let res = result -1L
  Assert.AreEqual([for i in 0..63 -> 1L], res)
[<Test>]
let ``input min output ? `` () =
  let res = result -9223372036854775808L
  Assert.AreEqual([|1L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L|], res)