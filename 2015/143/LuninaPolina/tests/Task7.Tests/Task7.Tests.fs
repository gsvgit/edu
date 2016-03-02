module Task7.Tests
open Task7
open NUnit.Framework

[<Test>]
let ``main return [|3;1;2;5|]`` () =
  let res = main [|2;1;3;5|] 0 2
  Assert.AreEqual([|3;1;2;5|], res)

[<Test>]
let ``main return [|1;2;3;4;5|]`` () =
  let res = main [|1;5;3;4;2|] 1 4
  Assert.AreEqual([|1;2;3;4;5|], res)

[<Test>]
let ``main return [|1;3;2;6;5|]`` () =
  let res = main [|1;3;6;2;5|] 2 3
  Assert.AreEqual([|1;3;2;6;5|], res)
