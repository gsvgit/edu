module Task2.Tests

open Task2
open NUnit.Framework

[<Test>]
let ``main (-1) = 2`` () = 
  let res = main -1
  Assert.AreEqual(2,result)

[<Test>]
let ``main (0) = 0`` () = 
  let res = main 0
  Assert.AreEqual(0,result)

[<Test>]
let ``main (1) = 4`` () = 
  let res = main -1
  Assert.AreEqual(4,result)