module Task23.Tests
open Task23
open NUnit.Framework

[<Test>]
let ``main [|4; 3; 2; 1|] = [|1; 2; 3; 4|]`` () = 
    let res = main [|4; 3; 2; 1|]
    Assert.AreEqual([|1; 2; 3; 4|], res)

[<Test>]
let ``main [|4; 1; 2; 1|] = [|1; 1; 2; 4|]`` () = 
    let res = main [|4; 1; 2; 1|]
    Assert.AreEqual([|1; 1; 2; 4|], res)

[<Test>]
let ``main [|1; 2; 3; 4|] = [|1; 2; 3; 4|]`` () = 
    let res = main [|1; 2; 3; 4|]
    Assert.AreEqual([|1; 2; 3; 4|], res)

[<Test>]
let ``main [||] = [||]`` () = 
    let res = main [||]
    Assert.AreEqual([||], res)
