module Task4.Tests

open Task4
open NUnit.Framework

[<Test>]
let ``Task4:main [|12; 25; 17; 46|] 19 returns [|0; 2|]`` () =
  let result = Library.main [|12; 25; 17; 46|] 19
  printfn "%A" result
  Assert.AreEqual([|0; 2|], result)

[<Test>]
let ``Task4:main [||] 9 returns [||]`` () =
  let result = Library.main [||] 9
  printfn "%A" result
  Assert.AreEqual([||], result)

[<Test>]
let ``Task4:main [|12; 25; 17; 46|] 98 returns [|0; 1; 2; 3|]`` () =
  let result = Library.main [|12; 25; 17; 46|] 98
  printfn "%A" result
  Assert.AreEqual([|0; 1; 2; 3|], result)