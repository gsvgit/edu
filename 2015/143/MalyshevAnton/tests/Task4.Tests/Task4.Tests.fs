module Task4.Tests

open Task4
open NUnit.Framework

[<Test>]
let ``main returns [|0; 1; 2; 4; 5; 7|]`` () =
  let result = main [|1; 4; 12; 20; 7; 9; 65; 5|] 15
  printfn "%A" result
  Assert.AreEqual([|0; 1; 2; 4; 5; 7|] , result)

[<Test>]
let ``main returns [||]`` () =
  let result = main [||] 10
  printfn "%A" result
  Assert.AreEqual([||] , result)

[<Test>]
let ``main returns [|0; 1; 3; 4|]`` () =   
  let result = main [|1; -10; 60; -31; -7; 42|] 20
  printfn "%A" result
  Assert.AreEqual([|0; 1; 3; 4|] , result)
