module Task12.Tests

open Task12
open NUnit.Framework

[<Test>]
let ``main 0 returns 0`` () =
  let result = main 0
  printfn "%A" result
  Assert.AreEqual(0 , result)

[<Test>]
let ``main 2 returns 1`` () =
  let result = main 2
  printfn "%A" result
  Assert.AreEqual(1 , result)

[<Test>]
let ``main 8 returns 21`` () =
  let result = main 8
  printfn "%A" result
  Assert.AreEqual(21 , result)