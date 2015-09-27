module Task6.Tests

open NUnit.Framework
open Task6

[<Test>]
let ``main [|1; 4|] returns [|4; 1|]``() =
    let result = main [|1; 4|]
    printfn "%A" result
    Assert.AreEqual([|4; 1|], result)
    
[<Test>]
let ``main [|1034; 4301|] returns [|4301; 1034|]``() =
    let result = main [|1034; 4301|]
    printfn "%A" result
    Assert.AreEqual([|4301; 1034|], result)
    
[<Test>]
let ``main [|100; 2|] returns [|2; 100|]``() =
    let result = main [|100; 2|]
    printfn "%A" result
    Assert.AreEqual([|2; 100|], result)