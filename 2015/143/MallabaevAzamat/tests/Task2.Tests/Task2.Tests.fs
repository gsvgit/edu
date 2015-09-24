module Task2.Tests

open Task2
open NUnit.Framework

[<Test>]
let ``Task2:main 0 returns 1`` () =
  let result = Library.main 0
  printfn "%i" result
  Assert.AreEqual(1,result)

[<Test>]
let ``Task2:main 1 returns 5`` () =
  let result = Library.main 1
  printfn "%i" result
  Assert.AreEqual(5,result)
  
[<Test>]
let ``Task2:main 10 returns 11111`` () =
  let result = Library.main 10
  printfn "%i" result
  Assert.AreEqual(11111,result)