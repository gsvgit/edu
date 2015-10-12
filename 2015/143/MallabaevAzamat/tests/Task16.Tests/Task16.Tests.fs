module Task16.Tests
open NUnit.Framework
open Task15
open Task16
      
[<Test>]                       
let ``main Nil returned 0`` () =
  let result = main Nil
  printfn "%i" result
  Assert.AreEqual(0, result)

[<Test>]
let ``main Cons(5, Nil) returned 1`` () =
  let result = main <| Cons(5, Nil)
  printfn "%i" result
  Assert.AreEqual(1, result)

[<Test>]
let ``main Cons('1', Cons('\0', Nil)) returned 2`` () =
  let result = main <| Cons('1', Cons('\u0000', Nil))
  printfn "%i" result
  Assert.AreEqual(2, result)
