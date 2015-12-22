module Task23.Tests

open Task23
open NUnit.Framework

[<Test>]
let ``already sort`` () =
    let result = main [|1; 2; 3; 4; 5; 6|]
    printfn "%A" result
    Assert.AreEqual(result, [|1; 2; 3; 4; 5; 6|])

[<Test>]
let ``empty`` () =
    let result = main [||]
    printfn "%A" result
    Assert.AreEqual(result, [||])

[<Test>]
let ``not sort`` () =
    let result = main [|1; 6; 3; 4; 5; 2|]
    printfn "%A" result
    Assert.AreEqual(result, [|1; 2; 3; 4; 5; 6|])

[<Test>]
let ``sorted in the opposite order`` () =
    let result = main [|6; 5; 4; 3; 2; 1|]
    printfn "%A" result
    Assert.AreEqual(result, [|1; 2; 3; 4; 5; 6|])
