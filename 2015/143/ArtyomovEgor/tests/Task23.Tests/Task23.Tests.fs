module Task23.Tests

open Task23
open NUnit.Framework

[<Test>]
let ``sort 1,2,3,4,5,6,7,8,9,10 return the same`` () =
  let inArr = [|1; 2; 3; 4; 5; 6; 7; 8; 9; 10|]
  let res = main inArr
  Assert.AreEqual(inArr, res)

[<Test>]
let ``sort 1,1,1,1,1 return the same`` () =
  let inArr = [|1; 1; 1; 1; 1|]
  let res = main inArr
  Assert.AreEqual(inArr, res)

[<Test>]
let ``sort 10,9,8,7,6,5,4,3,2,1 return 1,2,3,4,5,6,7,8,9,10`` () =
  let inArr = [|10; 9; 8; 7; 6; 5; 4; 3; 2; 1|]
  let res = main inArr
  Assert.AreEqual([|1; 2; 3; 4; 5; 6; 7; 8; 9; 10|], res)

[<Test>]
let ``sort 69,7,75,83,81,85,63,32,24,48 return 7,24,32,48,63,69,75,81,83,85`` () =
  let inArr = [|69; 7; 75; 83; 81; 85; 63; 32; 24; 48; 85|]
  let res = main inArr
  Assert.AreEqual([|7; 24; 32; 48; 63; 69; 75; 81; 83; 85; 85|], res)

[<Test>]
let ``sort Empty return Empty `` () =
  let inArr = [||]
  let res = main inArr
  Assert.AreEqual([||], res)