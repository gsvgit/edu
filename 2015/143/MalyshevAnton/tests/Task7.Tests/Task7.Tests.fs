module Task7.Tests

open Task7
open NUnit.Framework

[<Test>]
let ``main returns [|9; 3; -10; 65|]`` () =
  let result = main [|9; -10; 3; 65|] 1 2
  printfn "%A" result
  Assert.AreEqual([|9; 3; -10; 65|] , result)

[<Test>]
let ``main returns [|-11; 0|]`` () =
  let result = main [|0; -11|] 0 1
  printfn "%A" result
  Assert.AreEqual([|-11; 0|] , result)

[<Test>]
let ``main returns [|1; 2; 30; 41; 3; 5; 10|]`` () =
  let result = main [|5; 2; 30; 41; 3; 1; 10|] 0 5
  printfn "%A" result
  Assert.AreEqual([|1; 2; 30; 41; 3; 5; 10|] , result)