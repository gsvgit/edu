module Task5.Tests

open NUnit.Framework
open Task5

[<Test>]
let ``main [||] 19 110 returns [||]`` =
    let result = main [||] 19 110 
    printfn "%A" result
    Assert.AreEqual([||], result)
    
[<Test>]
let ``main [|15; 272; 2; 18; 89; 1111; 6545353|] 19 1110 returns [|1; 3; 4; 6; 7|]`` =
    let result = main [|15; 272; 2; 18; 89; 1111; 6545353|] 19 1110 
    printfn "%A" result
    Assert.AreEqual([|1; 3; 4; 6; 7|], result)
    
[<Test>]
let ``main [|100|] 19 110 returns [||]`` =
    let result = main [|100|] 19 110
    printfn "%A" result
    Assert.AreEqual([||], result)