module Task5.Tests
open Task5
open NUnit.Framework

[<Test>]
let ``main return [|0;2;4|]`` () =
  let res = main [|1;3;6;2;0|] 2 4
  Assert.AreEqual([|0;2;4|], res)

[<Test>]
let ``main return [|1|]`` () =
  let res = main [|1;0;2;3;4|] 1 10
  Assert.AreEqual([|1|], res)

[<Test>]
let ``main return [|0;1;2;3|]`` () =
  let res = main [|5;6;7;8|] 0 4
  Assert.AreEqual([|0;1;2;3|], res)