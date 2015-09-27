module Task7.Tests

open Task7
open NUnit.Framework

[<Test>]
let ``main [|5;-3;2|] 1 2 = [|5;2;-3|]`` () = 
  let res = main [|5;-3;2|] 1 2
  Assert.AreEqual([|5;2;-3|],res)

[<Test>]
let ``main [|1;2;3;4|] 0 3 = [|4;2;3;1|]`` () = 
  let res = main [|1;2;3;4|] 0 3
  Assert.AreEqual([|4;2;3;1|],res)

[<Test>]
let ``main [|1;2;4|] 1 2 = [|1;4;2|] `` () = 
  let res = main [|1;2;4|] 1 2
  Assert.AreEqual([|1;4;2|],res)