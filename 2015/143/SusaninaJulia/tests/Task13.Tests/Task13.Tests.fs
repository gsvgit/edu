module Task13.Tests

open Task13
open NUnit.Framework

[<Test>]
let ``Task13:main 5 returns [|1;1;2;3;5|]`` () =
  let result = main 5
  printfn "%A" result
  Assert.AreEqual([|1;1;2;3;5|],result)

[<Test>]
let ``Task13:main 1 returns [|1|]`` () =
  let result = main 1
  printfn "%A" result
  Assert.AreEqual([|1|],result)
  
[<Test>]
let ``Task13:main 7 returns [|1;1;2;3;5;8;13|]`` () =
  let result = main 7
  printfn "%A" result
  Assert.AreEqual([|1;1;2;3;5;8;13|],result)
