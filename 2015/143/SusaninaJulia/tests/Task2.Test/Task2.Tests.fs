module Task2.Tests

open Task2
open NUnit.Framework

[<Test>]
let ``Task2:main 5 returns 781`` () =
  let result = main 5
  printfn "%i" result
  Assert.AreEqual(781,result)

[<Test>]
let ``Task2:main 1 returns 5`` () =
  let result = main 1
  printfn "%i" result
  Assert.AreEqual(5,result)
  
[<Test>]
let ``Task2:main -1 returns 1`` () =
  let result = main -1
  printfn "%i" result
  Assert.AreEqual(1,result)