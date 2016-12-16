module Task13.Tests

open Task13
open NUnit.Framework

[<Test>]
let ``Task 13 main 5 = [|1; 1; 2; 3; 5; 8|]`` () = 
    let res = main 5
    Assert.AreEqual([|1; 1; 2; 3; 5; 8|], res)

[<Test>]
let ``Task 13 main 7 = [|1; 1; 2; 3; 5; 8; 13; 21|]`` () = 
    let res = main 7
    Assert.AreEqual([|1; 1; 2; 3; 5; 8; 13; 21|], res)

[<Test>]
let ``Task 13 main 0 = [|1|]`` () = 
    let res = main 0
    Assert.AreEqual([|1|], res)

[<Test>]
let ``Task 13 main -10 = [|1|]`` () = 
    let res = main -10
    Assert.AreEqual([|1|], res)
        
