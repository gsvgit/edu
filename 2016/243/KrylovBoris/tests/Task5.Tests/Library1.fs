module Task5.Tests

open Task5
open NUnit.Framework

[<Test>]
let ``Task5 main [|0; 1; 2; 3; 4; 5 |] 0 6 return [||]`` () =
  let res = main [|0; 1; 2; 3; 4; 5 |] 0 6
  Assert.AreEqual([||], res)

[<Test>]
let ``Task5 main [| 99; 55; 66; 33; 44; 77; 88; 22; 11 |] 40 80 return [| 0; 3; 6 |]`` () =
  let res = main [| 99; 55; 66; 33; 44; 77; 88; 22; 11 |] 40 80
  Assert.AreEqual([| 0; 3; 6; 7; 8 |], res)

[<Test>]
let ``Task5 main [|4; 3; 7|] 1 3 return [|0; 2|]`` () =
  let res = main [|4; 3; 7|] 1 3
  Assert.AreEqual([|0;2|], res)
