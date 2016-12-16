module Task4.Tests

open Task4
open NUnit.Framework

[<Test>]
let ``Task4 main [|0; 1; 2; 3; 4; 5 |] 3 return [| 0; 1; 2; 3 |]`` () =
    let res = main [|0; 1; 2; 3; 4; 5 |] 3
    Assert.AreEqual([| 0; 1; 2; 3 |], res)

[<Test>]
let ``Task4 main [| 99; 55; 66; 33; 44; 77; 88; 22; 11 |] 50 return [| 3; 4; 7; 8 |]`` () =
    let res = main [| 99; 55; 66; 33; 44; 77; 88; 22; 11 |] 50
    Assert.AreEqual([| 3; 4; 7; 8 |], res)

[<Test>]
let ``Task4 main [|4; 3; 7|] 1 return [||]`` () =
    let res = main [|4; 3; 7|] 1
    Assert.AreEqual([||], res)