module Task7.Tests

open Task7
open NUnit.Framework

[<Test>]
let ``main [||] 1 10 return [||]`` () =
  let res = main [||] 1 10
  Assert.AreEqual([||], res)

[<Test>]
let ``main [|0; 1; 2; 3; 4; 5; 6; 7; 8; 9; 10|] 3 8 return [|0; 1; 2; 8; 4; 5; 6; 7; 3; 9; 10|]`` () =
  let res = main [|0; 1; 2; 3; 4; 5; 6; 7; 8; 9; 10|] 3 8
  Assert.AreEqual([|0; 1; 2; 8; 4; 5; 6; 7; 3; 9; 10|], res)

[<Test>]
let ``main [|0; -1; -2; -3; -4; -5; -6; -7; -8; -9; -10|] 0 8 return [|-8; -1; -2; -3; -4; -5; -6; -7; 0; -9; -10|]`` () =
  let res = main [|0; -1; -2; -3; -4; -5; -6; -7; -8; -9; -10|] 0 8
  Assert.AreEqual([|-8; -1; -2; -3; -4; -5; -6; -7; 0; -9; -10|], res)

[<Test>]
let ``main [|100; 900; 8750; 7; 8750; 587|] 2 2 return [|100; 900; 8750; 7; 8750; 587|]`` () =
  let res = main [|100; 900; 8750; 7; 8750; 587|] 4 2
  Assert.AreEqual([|100; 900; 8750; 7; 8750; 587|], res)