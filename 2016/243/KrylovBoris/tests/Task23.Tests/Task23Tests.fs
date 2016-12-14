module Task23.Tests

open Task15
open Task23
open NUnit.Framework

[<Test>]
let ``Task 23 main [2, 9, 4, 6, 5] = [2, 4, 5, 6, 9]`` () =
    let arr = [|9; 2; 4; 6; 5|]
    let control = [|2; 4; 5; 6; 9|]
    let res = main arr
    Assert.AreEqual(control, res)

[<Test>]
let ``Task 23 main [] = []`` () =
    let res = main [||]
    Assert.AreEqual([||], res)

[<Test>]
let ``Task 23 main [6, 6, 7] = [6, 6, 7]`` () =
    let arr = [|6; 6; 7|]
    let res = main arr
    Assert.AreEqual(arr, res)

[<Test>]
let ``Task 23 main [1, 6, 7, 5] = [1, 5, 6, 7]`` () =
    let arr = [|1; 6; 7; 5|]
    let control = [|1; 5; 6; 7|]
    let res = main arr
    Assert.AreEqual(control, res)