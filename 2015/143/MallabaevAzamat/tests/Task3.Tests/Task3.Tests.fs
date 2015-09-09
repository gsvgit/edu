module Task3.Tests

open Task3
open NUnit.Framework

[<Test>]
let ``Task3:main 0 returns 0`` () =
  let result = Library.main 0
  printfn "%i" result
  Assert.AreEqual(0,result)

[<Test>]
let ``Task3:main 1 returns 4`` () =
  let result = Library.main 1
  printfn "%i" result
  Assert.AreEqual(4,result)
  
[<Test>]
let ``Task3:main 10 returns 11110`` () =
  let result = Library.main 10
  printfn "%i" result
  Assert.AreEqual(11110,result)