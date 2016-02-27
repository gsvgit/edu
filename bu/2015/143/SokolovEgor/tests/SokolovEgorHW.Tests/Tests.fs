module SokolovEgorHW.Tests

open SokolovEgorHW
open NUnit.Framework

[<Test>]
let ``hello returns 42`` () =
  let result = Library.hello
  printfn "%i" result
  Assert.AreEqual(42,result)
