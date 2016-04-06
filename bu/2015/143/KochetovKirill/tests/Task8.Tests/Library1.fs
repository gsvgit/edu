module Task8.Tests

open Task8
open NUnit.Framework

[<Test>]
let ``main 1 = 1`` () = 
  let res = main 1
  Assert.AreEqual(1,res)

[<Test>]
let ``main 2 = 1`` () = 
  let res = main 2
  Assert.AreEqual(1,res)

[<Test>]
let ``main 5 = 5`` () = 
  let res = main 5
  Assert.AreEqual(5,res)

[<Test>]
let ``main 7 = 13`` () = 
  let res = main 7
  Assert.AreEqual(13,res)
