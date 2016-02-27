module Task4.Tests

open Task4
open NUnit.Framework

[<Test>]
let ``main [|1;2;3;4|] 2 = [|0;1|]`` () = 
  let res = main [|1;2;3;4|] 2
  Assert.AreEqual([|0;1|],res)

[<Test>]
let ``main [|4;3;2;1|] 2 = [|2;3|]`` () = 
  let res = main [|4;3;2;1|] 2
  Assert.AreEqual([|2;3|],res)

[<Test>]
let ``main [|1;2;3;4|] 0 = [||]`` () = 
  let res = main [|1;2;3;4|] 0
  Assert.AreEqual([||],res)