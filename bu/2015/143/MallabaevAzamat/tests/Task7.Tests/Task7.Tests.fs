module Task7.Tests

open NUnit.Framework
open Task7

[<Test>]
let ``main [||] 19 19 returns [||]``() =
    let result = main [||] 19 19
    printfn "%A" result
    Assert.AreEqual([||], result)
    
[<Test>]
let ``main [|15; 272; 2; 6545353|] 1 3 returns [|15; 6545353; 2; 272|]``() =
    let result = main [|15; 272; 2; 6545353|] 1 3
    printfn "%A" result
    Assert.AreEqual([|15; 6545353; 2; 272|], result)
    
[<Test>]
let ``main [|100; 2|] 0 1 returns [|2; 100|]``() =
    let result = main [|100; 2|] 0 1
    printfn "%A" result
    Assert.AreEqual([|2; 100|], result)