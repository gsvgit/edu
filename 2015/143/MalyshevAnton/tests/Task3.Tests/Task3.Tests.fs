module Task3.Tests

open Task3
open NUnit.Framework

[<Test>]
let ``Task3:main 0 returns 1`` () =
  let res = Task3.main 0
  printfn "%i" res
  Assert.AreEqual(1,res)

[<Test>]
let ``Task3:main 1 returns 5`` () =
  let res = Task3.main 1
  printfn "%i" res
  Assert.AreEqual(5,res)
  
[<Test>]
let ``Task3:main -2 returns 11`` () =
  let res = Task3.main -2
  printfn "%i" res
  Assert.AreEqual(11,res) 
