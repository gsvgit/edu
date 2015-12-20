﻿module Task27.Tests

open NUnit.Framework
open Task27

[<Test>]
let ``Task27 : main 446.15625 returns`` () =
    let res = main 446.15625
    Assert.AreEqual("0100000001111101111100010100000000000000000000000000000000000000" |> ignore, res)

[<Test>]
let ``Task27 : main 0 returns 0000000000000000000000000000000000000000000000000000000000000000`` () =
    let res = main 0.0
    Assert.AreEqual("0000000000000000000000000000000000000000000000000000000000000000" |> ignore, res)

[<Test>]
let ``Task27 : main -818,375 returns 1100000010001001100100110000000000000000000000000000000000000000`` () =
    let res = main -818.375
    Assert.AreEqual("1100000010001001100100110000000000000000000000000000000000000000" |> ignore, res)