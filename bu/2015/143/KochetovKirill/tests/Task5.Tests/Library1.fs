module Task5.Tests

open Task5
open NUnit.Framework


[<Test>]
let ``main [|1; 2; 3; 4|] 2 3 = [|0;3|]`` () = 
  let res = main [|1; 2; 3; 4|] 2 3
  Assert.AreEqual([|0;3|],res)

[<Test>]
let ``main [|1; 2; 3; 4|] 3 3 = [|0;1;3|]`` () = 
  let res = main [|1; 2; 3; 4|] 3 3
  Assert.AreEqual([|0;1;3|],res)

[<Test>]
let ``main [|1; 2; 3; 4|] 1 4 = [||]`` () = 
  let res = main [|1; 2; 3; 4|] 1 4
  Assert.AreEqual([||],res)
