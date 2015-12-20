module Task27.Tests

open NUnit.Framework
open Task27

[<Test>]
let ``return [|0; 1; 3; 50; 100|], unsorted`` () =
  let res = main
  Assert.AreEqual([|0; 1; 3; 50; 100|], res)