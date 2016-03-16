module Task23.Tests

open NUnit.Framework
open Task23

[<Test>]
let ``return [|100; 50; 3; 1; 0|], unsorted`` () =
  let res = main [|100; 50; 3; 1; 0|]
  Assert.AreEqual([|0; 1; 3; 50; 100|], res)
[<Test>]
let ``return [|0|], zero`` () = 
  let res = main [|0|]
  Assert.AreEqual([|0|], res)
[<Test>]
let ``return [||], empty`` () = 
  let res = main [||]
  Assert.AreEqual([||], res)
[<Test>]
let ``return [|1; 2; 3; 4; 5|], sorted`` () =
  let res = main [|1; 2; 3; 4; 5|]
  Assert.AreEqual([|1; 2; 3; 4; 5|], res)
[<Test>]
let ``return [|5; 3; 2; 5; 1|], not sorted`` () =
  let res = main [|5; 3; 2; 5; 1|]
  Assert.AreEqual([|1; 2; 3; 5; 5|], res)