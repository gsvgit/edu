module Task5.Tests

open Task5
open NUnit.Framework

[<Test>]
let ``main [||] 0 10 return [||]`` () =
  let res = main [||] 0 10
  Assert.AreEqual([||], res)

[<Test>]
let ``main [|0; 1; 2; 3; 4; 5; 6; 7; 8; 9; 10|] 3 7 return [|0; 1; 2; 8; 9; 10|]`` () =
  let res = main [|0; 1; 2; 3; 4; 5; 6; 7; 8; 9; 10|] 3 7
  Assert.AreEqual([|0; 1; 2; 8; 9; 10|], res)

[<Test>]
let ``main [|10; 9; 8; 7; 6; 5; 4; 3; 2; 1; 0|] 9 1 return [|0; 10|]`` () =
  let res = main [|10; 9; 8; 7; 6; 5; 4; 3; 2; 1; 0|] 9 1
  Assert.AreEqual([|0; 10|], res)

[<Test>]
let ``main [|256; 100; 853 ; 781; 1256|] 200 1000 return [|1; 4|]`` () =
  let res = main [|256; 100; 853 ; 781; 1256|] 200 1000
  Assert.AreEqual([|1; 4|], res)