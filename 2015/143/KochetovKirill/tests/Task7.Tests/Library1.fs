module Task7.Tests

open Task7
open NUnit.Framework

[<Test>]
let ``main [|1|] 1 1 = [|1|]`` () = 
  let res = main [|1|] 1 1
  Assert.AreEqual([|1|],res)

[<Test>]
let ``main [|1;2;3;4|] 1 4 = [|4;2;3;1|]`` () = 
  let res = main [|1;2;3;4|] 1 4
  Assert.AreEqual([|4;2;3;1|],res)

[<Test>]
let ``main [|1;2;4|] 5 6 = [|1;2;4|] `` () = 
  let res = main [|1;2;4|] 5 6
  Assert.AreEqual([|1;2;4|],res)