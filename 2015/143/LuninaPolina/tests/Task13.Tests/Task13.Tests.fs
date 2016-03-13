module Task13.Tests
open Task13
open NUnit.Framework

[<Test>]
let ``main return [|0;1;1;2|]`` () =
  let res = main 3
  Assert.AreEqual([|0;1;1;2|], res)

[<Test>]
let ``main return [|0;1;1;2;3;5|]`` () =
  let res = main 5
  Assert.AreEqual([|0;1;1;2;3;5|], res)

[<Test>]
let ``main return [|0;1;1;2;3;5;8;13|]`` () =
  let res = main 7
  Assert.AreEqual([|0;1;1;2;3;5;8;13|], res)
