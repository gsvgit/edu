module Task23.Tests

open NUnit.Framework
open Task23

[<Test>]
let ``Task23: main [|2;6;1;5;3;9;13;2;56|] returns [|1;2;2;3;5;6;9;13;56|]`` () =
  let res = main [|2;6;1;5;3;9;13;2;56|]
  Assert.AreEqual([|1;2;2;3;5;6;9;13;56|], res)

[<Test>]
let ``Task23: main [|0|] returns [|0|]`` () = 
  let res = main [|0|]
  Assert.AreEqual([|0|], res)

[<Test>]
let ``Task23: main [||] returns [||]`` () = 
  let res = main [||]
  Assert.AreEqual([||], res)
