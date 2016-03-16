module Task7.Tests

open Task7
open NUnit.Framework

[<Test>]
let ``Task7:main [|2;12;4;8;9;13;12;1;6;7|] 4 5 returns [|2;12;4;8;13;9;12;1;6;7|]`` () =
  let result = main [|2;12;4;8;9;13;12;1;6;7|] 4 5
  printfn "%A" result
  Assert.AreEqual([|2;12;4;8;13;9;12;1;6;7|], result)

[<Test>]
let ``Task7:main [|1;3;2|] 1 2  returns [|1;2;3|]`` () =
  let result = main [|1;3;2|] 1 2
  printfn "%A" result
  Assert.AreEqual([|1;2;3|], result)

[<Test>]
let ``Task7:main [|15;13;6;9|] 0 3 returns [|9;13;6;15|]`` () =
  let result = main [|15;13;6;9|] 0 3
  printfn "%A" result
  Assert.AreEqual([|9;13;6;15|], result)
