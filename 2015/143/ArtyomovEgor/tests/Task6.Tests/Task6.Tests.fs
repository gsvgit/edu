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
  printfn "%A" res
  Assert.AreEqual([|1; 0|], res)

[<Test>]
let ``main [|1; 1|] return [|1; 1|]`` () =
  let res = main  [|1; 1|]
  Assert.AreEqual([|1; 1|], res)

[<Test>]
let ``main [|-5; -200|] return [|-200; -5|]`` () =
  let res = main  [|-5; -200|]
  Assert.AreEqual([|-200; -5|], res)