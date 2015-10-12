module Task13.Tests

open Task13
open NUnit.Framework

[<Test>]
let ``main 2 = [|1;1|]`` () = 
  let res = main 2
  Assert.AreEqual([|1;1|], res)

[<Test>]
let ``main 5 = [|1;1;2;3;5|]`` () = 
  let res = main 5
  Assert.AreEqual([|1;1;2;3;5|], res)

[<Test>]
let ``main 7 = [|1;1;2;3;5;8;13|]`` () = 
  let res = main 7
  Assert.AreEqual([|1;1;2;3;5;8;13|], res)

[<Test>]
let ``main 0 = [||]`` () = 
  let res = main 0
  Assert.AreEqual([||], res)