module TaskA.Tests
open NUnit.Framework
open TaskA
      
[<Test>]                       
let ``main -10 returned -55`` () =
  let result = main -10
  printfn "%i" result
  Assert.AreEqual(-55, result)

[<Test>]
let ``main -5 returned 5`` () =
  let result = main -5
  printfn "%i" result
  Assert.AreEqual(5, result)

[<Test>]
let ``main 0 returned 0`` () =
  let result = main 0
  printfn "%i" result
  Assert.AreEqual(0, result)

[<Test>]
let ``main 1 returned 1`` () =
  let result = main 1
  printfn "%i" result
  Assert.AreEqual(1, result)

[<Test>]
let ``main 5 returned 5`` () =
  let result = main 5
  printfn "%i" result
  Assert.AreEqual(5, result)

[<Test>]
let ``main 10 returned 55`` () =
  let result = main 10
  printfn "%i" result
  Assert.AreEqual(55, result)