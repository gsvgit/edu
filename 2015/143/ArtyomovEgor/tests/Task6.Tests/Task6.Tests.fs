module Task6.Tests

open Task6
open NUnit.Framework

[<Test>]
let ``main [||] return [||]`` () =
  let res = main [||]
  Assert.AreEqual([||], res)

[<Test>]
let ``main [|0; 1|] return [|1; 0|]`` () =
  let res = main [|0; 1|]
  Assert.AreEqual([|1; 0|], res)

[<Test>]
let ``main [|0; 0|] return [|0; 0|]`` () =
  let res = main [|0; 0|]
  Assert.AreEqual([|0; 0|], res)

[<Test>]
let ``main [|1; 0|] return [|0; 1|]`` () =
  let res = main [|1; 0|]
  Assert.AreEqual([|0; 1|], res)

[<Test>]
let ``main [|-1; 5|] return [|5; -1|]`` () =
  let res = main [|-1; 5|]
  Assert.AreEqual([|5; -1|], res)

[<Test>]
let ``main [|-1; -5|] return [|-5; -1|]`` () =
  let res = main [|-1; -5|]
  Assert.AreEqual([|-5; -1|], res)