module Task7.Tests

open Task7
open NUnit.Framework

[<Test>]
let ``main return [|2; 1|]`` () =
  let res = main [|1; 2|] 0 1
  Assert.AreEqual([|2; 1|], res)

[<Test>]
let ``main return [|-1; 13; 12; 4; 0; 2|]`` () =
  let res = main [|-1; 0; 12; 4; 13; 2|] 1 4
  Assert.AreEqual([|-1; 13; 12; 4; 0; 2|], res)

[<Test>]
let ``main return [|-1; -1; 7; 17; 3|]`` () =
  let res = main [|-1; 3; 7; 17; -1|] 4 1
  Assert.AreEqual([|-1; -1; 7; 17; 3|], res)

