module Task27.Test

open Task27
open NUnit.Framework

[<Test>]
let ``main -2.32 =`` () =
    let res = main -2.32
    Assert.AreEqual("1100000000000010100011110101110000101000111101011100001010001111", res)

[<Test>]
let ``main 0 =`` () = 
    let res = main 0.0
    Assert.AreEqual("0000000000000000000000000000000000000000000000000000000000000000", res)

[<Test>]
let ``main 128.64 =`` () = 
    let res = main 128.64
    Assert.AreEqual("0100000001100000000101000111101011100001010001111010111000010100", res)

[<Test>]
let ``main -0 =`` () = 
    let res = main -0.0
    Assert.AreEqual("0000000000000000000000000000000000000000000000000000000000000000", res)
