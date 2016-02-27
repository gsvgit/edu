module Task4.Tests

open Task4
open NUnit.Framework

[<Test>]
let ``main return [|0; 1; 2; 3; 4|]`` () =
  let res = main [|1; 2; 3; 4; 5; 6; 7; 8; 9; 10|] 5
  Assert.AreEqual([|0; 1; 2; 3; 4|], res)

[<Test>]
let ``main return [|1; 2; 3; 4|]`` () =
  let res = main [|100; 50; 3; 1; 0|] 50
  Assert.AreEqual([|1; 2; 3; 4|], res)

[<Test>]
let ``main return [|0, 1, 3|]`` () =
  let res = main [|-1; 12; 17; 0; 13|] 12
  Assert.AreEqual([|0; 1; 3|], res)
