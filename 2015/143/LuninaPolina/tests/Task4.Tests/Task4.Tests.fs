module Task4.Tests
open Task4
open NUnit.Framework

[<Test>]
let ``main return [|0;2;4|]`` () =
  let res = main [|1;5;2;7;2|] 4
  Assert.AreEqual([|0;2;4|], res)

[<Test>]
let ``main return [|0;1;2;3|]`` () =
  let res = main [|0;1;2;2;10|] 2
  Assert.AreEqual([|0;1;2;3|], res)

[<Test>]
let ``main return [|3|]`` () =
  let res = main [|9;5;4;1|] 2
  Assert.AreEqual([|3|], res)