module Task5.Tests

open NUnit.Framework
open Task5

let ``main [||] 19 110 returns [||]`` =
    let result = main [||] 19 110 
    printfn "%A" result
    Assert.AreEqual([||], result)

let ``main [|15; 272; 2; 18; 89; 1111; 6545353|] 19 1110 returns [|15; 2; 18; 1111; 6545353|]`` =
    let result = main [|15; 272; 2; 18; 89; 1111; 6545353|] 19 1110 
    printfn "%A" result
    Assert.AreEqual([|15; 2; 18; 1111; 6545353|], result)
    
let ``main [|100|] 19 110 returns [||]`` =
    let result = main [|100|] 19 110 
    printfn "%A" result
    Assert.AreEqual([||], result)