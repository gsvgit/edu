module Task6.Tests

open Task6
open NUnit.Framework

[<Test>]
let ``Task6:main [|2;12|] returns [|12;2|]`` () =
  let result = main [|2;12|]
  printfn "%A" result
  Assert.AreEqual([|12;2|], result)

[<Test>]
let ``Task6:main [|1;4;8;12|] returns [|4;1;8;12|]`` () =
  let result = main [|1;4;8;12|]
  printfn "%A" result
  Assert.AreEqual([|4;1;8;12|], result)

[<Test>]
let ``Task6:main [|15;13|] returns [|13;15|]`` () =
  let result = main [|15;13|]
  printfn "%A" result
  Assert.AreEqual([|13;15|], result)
