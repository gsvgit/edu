module Task15.Tests

open Task15
open NUnit.Framework

[<Test>]
let ``main [||] return [||]`` () =
  let res = bubble [||]
  Assert.AreEqual([||], res)

[<Test>]
let ``main [|0; 1; 2; 3; 4; 5; 6; 7; 8; 9; 10|] return [|0; 1; 2; 3; 4; 5; 6; 7; 8; 9; 10|]`` () =
  let res = bubble [|0; 1; 2; 3; 4; 5; 6; 7; 8; 9; 10|]
  Assert.AreEqual([|0; 1; 2; 3; 4; 5; 6; 7; 8; 9; 10|], res)

[<Test>]
let ``main [|0; -1; -2; -3; -4; -5; -6; -7; -8; -9; -10|] return [|-10; -9; -8; -7; -6; -5; -4; -3; -2; -1; 0|]`` () =
  let res = bubble [|0; -1; -2; -3; -4; -5; -6; -7; -8; -9; -10|]
  Assert.AreEqual([|-10; -9; -8; -7; -6; -5; -4; -3; -2; -1; 0|], res)

[<Test>]
let ``main [|1; 10; 5; 7; 2; 4; 8; 3; 6; 9; 0|] return [|0; 1; 2; 3; 4; 5; 6; 7; 8; 9; 10|]`` () =
  let res = bubble [|1; 10; 5; 7; 2; 4; 8; 3; 6; 9; 0|]
  Assert.AreEqual([|0; 1; 2; 3; 4; 5; 6; 7; 8; 9; 10|], res)