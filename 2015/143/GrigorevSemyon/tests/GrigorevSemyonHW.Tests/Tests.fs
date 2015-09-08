module GrigorevSemyonHW.Tests

open GrigorevSemyonHW
open NUnit.Framework

[<Test>]
let ``hello returns 5`` () =  
  let res = f 3
  Assert.AreEqual(6, res)

[<Test>]
let ``hello returns 0`` () =  
  let res = f -3
  Assert.AreEqual(0, res)
