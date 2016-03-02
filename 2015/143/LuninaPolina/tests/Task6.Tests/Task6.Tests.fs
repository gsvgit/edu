module Task6.Tests
open Task6
open NUnit.Framework

[<Test>]
let ``main return [|1;2|]`` () =
  let res = main [|2;1|]
  Assert.AreEqual([|1;2|], res)

[<Test>]
let ``main return [|3;5|]`` () =
  let res = main [|5;3|]
  Assert.AreEqual([|3;5|], res)

[<Test>]
let ``main return [|2;2|]`` () =
  let res = main [|2;2|]
  Assert.AreEqual([|2;2|], res)