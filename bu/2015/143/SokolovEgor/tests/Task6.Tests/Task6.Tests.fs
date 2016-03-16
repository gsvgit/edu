module Task6.Tests

open Task6
open NUnit.Framework

[<Test>]
let ``main return [|2; 1|]`` () =
  let res = main [|1; 2|]
  Assert.AreEqual([|2; 1|], res)

[<Test>]
let ``main return [|0; -1|]`` () =
  let res = main [|-1; 0|]
  Assert.AreEqual([|0; -1|], res)

[<Test>]
let ``main return [|-1; -1|]`` () =
  let res = main [|-1; -1|]
  Assert.AreEqual([|-1; -1|], res)

[<Test>]
let ``main return [|12; 0|]`` () =
  let res = main [|0; 12|]
  Assert.AreEqual([|12; 0|], res)

