module Task13.Tests

open Task13
open NUnit.Framework

[<Test>]
let ``Task 13 main 5 = [|0;1;1;2;3;5|]`` () = 
    let res = main 5
    Assert.AreEqual([|0;1;1;2;3;5|], res)

[<Test>]
let ``Task 13 main 7 = [|0;1;1;2;3;5;8;13|]`` () = 
    let res = main 7
    Assert.AreEqual([|0;1;1;2;3;5;8;13|], res)

[<Test>]
let ``Task 13 main 0 = [|0|]`` () = 
    let res = main 0
    Assert.AreEqual([|0|], res)
