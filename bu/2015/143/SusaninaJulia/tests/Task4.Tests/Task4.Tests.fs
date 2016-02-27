module Task4.Tests

open Task4
open NUnit.Framework

[<Test>]
let ``Task4:main [|2;12;4;8;9;13;12;1;6;7|] 4 returns [|0;2;7|]`` () =
  let result = main [|2;12;4;8;9;13;12;1;6;7|] 4
  printfn "%A" result
  Assert.AreEqual([|0;2;7|], result)

[<Test>]
let ``Task4:main [||] 4 returns [||]`` () =
  let result = main [||] 4
  printfn "%A" result
  Assert.AreEqual([||], result)

[<Test>]
let ``Task4:main [|15;13;6;9|] 21 returns [|0;1;2;3|]`` () =
  let result = main [|15;13;6;9|] 21
  printfn "%A" result
  Assert.AreEqual([|0;1;2;3|], result)
