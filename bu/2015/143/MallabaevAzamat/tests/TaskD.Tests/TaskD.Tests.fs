module TaskD.Tests
open NUnit.Framework
open TaskD
      
[<Test>]                       
let ``main 0 returned [|0|]`` () =
  let result = main 0
  printfn "%A" result
  Assert.AreEqual([|0|], result)

[<Test>]
let ``main 1 returned [|0; 1|]`` () =
  let result = main 1
  printfn "%A" result
  Assert.AreEqual([|0; 1|], result)

[<Test>]
let ``main 5 returned [|0; 1; 1; 2; 3; 5|]`` () =
  let result = main 5
  printfn "%A" result
  Assert.AreEqual([|0; 1; 1; 2; 3; 5|], result)

[<Test>]
let ``main -5 returned [|0; 1; -1; 2; -3; 5|]`` () =
  let result = main -5
  printfn "%A" result
  Assert.AreEqual([|0; 1; -1; 2; -3; 5|], result)

[<Test>]
let ``main 10 returned [|0; 1; 1; 2; 3; 5; 8; 13; 21; 34; 55|]`` () =
  let result = main 10
  printfn "%A" result
  Assert.AreEqual([|0; 1; 1; 2; 3; 5; 8; 13; 21; 34; 55|], result)

[<Test>]
let ``main -10 returned [|0; 1; -1; 2; -3; 5; -8; 13; -21; 34; -55|]`` () =
  let result = main -10
  printfn "%A" result
  Assert.AreEqual([|0; 1; -1; 2; -3; 5; -8; 13; -21; 34; -55|], result)
