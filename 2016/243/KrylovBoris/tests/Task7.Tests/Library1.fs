module Task7.Tests

open Task7
open NUnit.Framework

[<Test>]
let ``Task5 main [|0; 1; 2; 3; 4; 5 |] 0 5 return [|5; 1; 2; 3; 4; 0 |]`` () =
    let res = main [|0; 1; 2; 3; 4; 5 |] 0 5
    Assert.AreEqual([|5; 1; 2; 3; 4; 0 |], res)

[<Test>]
let ``Task5 main [| 99; 55; 66; 33; 44; 77; 88; 22; 11 |] 4 7 return [| 99; 55; 66; 33; 22; 77; 88; 44; 11 |]`` () =
    let res = main [| 99; 55; 66; 33; 44; 77; 88; 22; 11 |] 4 7
    Assert.AreEqual([| 99; 55; 66; 33; 22; 77; 88; 44; 11 |], res)

[<Test>]
let ``Task5 main [|4; 3; 7|] 1 2 return [|4; 7; 3|]`` () =
    let res = main [|4; 3; 7|] 1 2
    Assert.AreEqual([|4; 7; 3|], res)
