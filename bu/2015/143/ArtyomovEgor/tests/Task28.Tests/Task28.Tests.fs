module Task28.Tests

open Task28
open NUnit.Framework

[<Test>]
let ``0`` () =
  let input = 0
  let res = arraymain input
  Assert.AreEqual([|0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0|], res)

[<Test>]
let ``main 1 return 1`` () =
  let input = 1
  let res = arraymain input
  Assert.AreEqual([|0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;1|], res)

[<Test>]
let ``main -1 return 11...1 -> `` () =
  let input = -1
  let res = arraymain input
  Assert.AreEqual([|1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1|], res)

[<Test>]
let ``-2147483648 return 100...0`` () =
  let input = -2147483648
  let res = arraymain input
  Assert.AreEqual([|1;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0|], res)

[<Test>]
let ``2147483647 return 011...1`` () =
  let input = 2147483647
  let res = arraymain input
  Assert.AreEqual([|0;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1|], res)