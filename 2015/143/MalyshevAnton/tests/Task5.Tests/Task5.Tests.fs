module Task5.Tests

open Task5
open NUnit.Framework

[<Test>]
let ``main returns [|0; 1; 3; 6; 7|]`` () = 
  let result = main [|1; 4; 12; 20; 7; 9; 65; 5|] 7 16
  printfn "%A" result
  Assert.AreEqual([|0; 1; 3; 6; 7|] , result)

[<Test>]
let ``main returns [||]`` () =
  let result = main [||] 5 30
  printfn "%A" result
  Assert.AreEqual([||] , result)

[<Test>]
let ``main returns [|2; 3; 5|]`` () =
  let result = main [|1; -10; 60; -31; -7; 42|] -15 40
  printfn "%A" result
  Assert.AreEqual([|2; 3; 5|] , result)

[<Test>]
let ``main 2 returns [||]`` () =
  let result = main [|1; 12; -7; 15; 36|] -100 100
  printfn "%A" result
  Assert.AreEqual([||] , result)