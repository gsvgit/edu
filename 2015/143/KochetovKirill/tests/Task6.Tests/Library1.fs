module Task6.Tests

open Task6
open NUnit.Framework

[<Test>]
let ``main [|-1;1|] = [|1;-1|]`` () = 
  let res = main [|-1;1|]
  Assert.AreEqual([|1;-1|],res)

[<Test>]
let ``main [|0;1|] = [|1;0|]`` () = 
  let res = main [|0;1|]
  Assert.AreEqual([|1;0|],res)

[<Test>]
let ``main [|3;5|] = [|5;3|]`` () = 
  let res = main [|3;5|]
  Assert.AreEqual([|5;3|],res)
