module Task13.Tests

open Task13
open NUnit.Framework

[<Test>]
let ``main 0 returns [|0|]`` () =
  let result = main 0
  printfn "%A" result
  Assert.AreEqual([|0|] , result)

[<Test>]
let ``main 2 returns [|0; 1; 1|]`` () =
  let result = main 2
  printfn "%A" result
  Assert.AreEqual([|0; 1; 1|] , result)

[<Test>]
let ``main 8 returns [|0; 1; 1; 2; 3; 5; 8; 13; 21|]`` () =
  let result = main 8
  printfn "%A" result
  Assert.AreEqual([|0; 1; 1; 2; 3; 5; 8; 13; 21|] , result)