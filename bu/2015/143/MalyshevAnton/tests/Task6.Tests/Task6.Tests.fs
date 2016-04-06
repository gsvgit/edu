module Task6.Tests

open Task6
open NUnit.Framework

[<Test>]
let ``main returns [|1; 9|]`` () =
  let result = main [|9; 1|]
  printfn "%A" result
  Assert.AreEqual([|1; 9|] , result)

[<Test>]
let ``main returns [|-11; 0|]`` () =
  let result = main [|0; -11|]
  printfn "%A" result
  Assert.AreEqual([|-11; 0|] , result)

[<Test>]
let ``main returns [|100; 100|]`` () =
  let result = main [|100 ; 100|]
  printfn "%A" result
  Assert.AreEqual([|100; 100|] , result)