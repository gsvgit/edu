module Task6.Tests

open Task6
open NUnit.Framework

[<Test>]
let ``Task6 main [|0; 1|] return [|1; 0|]`` () =
    let res = main  [|0; 1|]
    Assert.AreEqual([|1; 0|], res)

[<Test>]
let ``Task6 main [|63; 34|] return [|34; 63|]`` () =
    let res = main [|63; 34|]
    Assert.AreEqual([|34; 63|], res)

[<Test>]
let ``Task6 main [|81; 5|]  return [|5; 81|]`` () =
    let res = main [|81; 5|]
    Assert.AreEqual([|5; 81|], res)
