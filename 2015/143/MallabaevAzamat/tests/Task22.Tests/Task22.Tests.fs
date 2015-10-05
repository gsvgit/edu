module Task22.Tests
open NUnit.Framework
open Task22
                                            
[<Test>]
let ``main [||] returned 1`` () =
  let result = main [||]
  printfn "%A" result
  Assert.AreEqual([||], result)

[<Test>]
let ``main [|42|] returned 10`` () =
  let result = main [|42|]
  printfn "%A" result
  Assert.AreEqual([|42|], result)

[<Test>]                       
let ``main [|12, 2, 45|] returned [|2, 12, 45|]`` () =
  let result = main [|12, 2, 45|]
  printfn "%A" result
  Assert.AreEqual([|2, 12, 45|], result)
