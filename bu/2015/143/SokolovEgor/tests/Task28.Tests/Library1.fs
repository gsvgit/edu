module Task28.Tests

open NUnit.Framework
open Task28

[<Test>]
let ``input intMin`` () =
  let res = result -2147483648
  Assert.AreEqual([|1; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0|], res)

[<Test>]
let ``input 1`` () = 
  let res = result 1
  Assert.AreEqual([|0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 1|], res)

[<Test>]
let ``input -1`` () = 
  let res = result -1
  Assert.AreEqual([|1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1; 1|], res)

