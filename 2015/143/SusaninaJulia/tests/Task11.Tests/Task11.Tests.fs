module Task11.Tests

open Task11
open NUnit.Framework

[<Test>]
let ``Task11:main 5 returns 5`` () =
  let result = main 5
  printfn "%i" result
  Assert.AreEqual(5,result)

[<Test>]
let ``Task11:main 4 returns 3`` () =
  let result = main 4
  printfn "%i" result
  Assert.AreEqual(3,result)
  
[<Test>]
let ``Task11:main 7 returns 13`` () =
  let result = main 7
  printfn "%i" result
  Assert.AreEqual(13,result)