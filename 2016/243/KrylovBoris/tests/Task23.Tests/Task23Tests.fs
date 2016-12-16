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
let ``Task 23 main [-3, 5, -65, 6, 5, 5, -8, -7, -99, 5] = [-99, -65, -8, -7, -3, 5, 5, 5, 5, 6]`` () =
    let arr = [|-3; 5; -65; 6; 5; 5; -8; -7; -99; 5|]
    let control = [|-99; -65; -8; -7; -3; 5; 5; 5; 5; 6|]
    let res = main arr
    Assert.AreEqual(control, res)

[<Test>]
let ``Task 23 main [] = []`` () =
    let res = main [||]
    Assert.AreEqual([||], res)