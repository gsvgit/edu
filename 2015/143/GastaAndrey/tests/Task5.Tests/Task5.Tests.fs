module Task5.Tests

open Task5
open NUnit.Framework

[<Test>]
let ``main return [|0; 1; 2; 3; 8; 9; 10|]`` () =
  let res = main [|1; 2; 3; 4; 5; 6; 7; 8; 9; 10; 11|] 5 8
  Assert.AreEqual([|0; 1; 2; 3; 8; 9; 10|], res)

[<Test>]
let ``main return [|1; 2; 3; 4|]`` () =
  let res = main [|100; 50; 3; 1; 0|] 50 99
  Assert.AreEqual([|0; 2; 3; 4|], res)

[<Test>]
let ``main return [|0; 3; 5|]`` () =
  let res = main [|-1; 12; 17; 0; 13; 20|] 12 17
  Assert.AreEqual([|0; 3; 5|], res)
