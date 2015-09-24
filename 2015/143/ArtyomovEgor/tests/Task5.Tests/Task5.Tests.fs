module Task5.Tests

open Task5
open NUnit.Framework

[<Test>]
let ``main [||] 1 10 return [||]`` () =
  let res = main [||] 1 10
  Assert.AreEqual([||], res)

[<Test>]
let ``main [|0; 1; 2; 3; 4; 5; 6; 7; 8; 9; 10|] 3 8 return [|0; 1; 2; 9; 10|]`` () =
  let res = main [|0; 1; 2; 3; 4; 5; 6; 7; 8; 9; 10|] 3 8
  Assert.AreEqual([|0; 1; 2; 9; 10|], res)

[<Test>]
let ``main [|10; 9; 8; 7; 6; 5; 4; 3; 2; 1; 0|] 3 8 return [|0; 1; 2; 8; 9; 10|]`` () =
  let res = main [|10; 9; 8; 7; 6; 5; 4; 3; 2; 1; 0|] 3 8
  Assert.AreEqual([|0; 1; 8; 9; 10|], res)

[<Test>]
let ``main [|100; 900; 8750; 7; 61; 587|] 0 10000 return [||]`` () =
  let res = main [|100; 900; 8750; 7; 61; 587|] 0 10000
  Assert.AreEqual([||], res)