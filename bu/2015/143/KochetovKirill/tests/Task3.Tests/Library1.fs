module Task3.Tests

open Task3
open NUnit.Framework

[<Test>]
let ``main (-1) = 1`` () = 
  let res = main -1
  Assert.AreEqual(1,res)

[<Test>]
let ``main (0) = 1`` () = 
  let res = main 0
  Assert.AreEqual(1,res)

[<Test>]
let ``main (1) = 5`` () = 
  let res = main 1
  Assert.AreEqual(5,res)
