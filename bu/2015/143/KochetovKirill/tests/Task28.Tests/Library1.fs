module Task28.Test

open Task28
open NUnit.Framework

[<Test>]
let ``main 0 =`` () =
    let res = main 0
    Assert.AreEqual("00000000000000000000000000000000", res)

[<Test>]
let ``main 128 =`` () = 
    let res = main 128
    Assert.AreEqual("00000000000000000000000010000000", res)

[<Test>]
let ``main -456 =`` () = 
    let res = main -456
    Assert.AreEqual("11111111111111111111111000111000", res)

[<Test>]
let ``main -0 =`` () = 
    let res = main -0
    Assert.AreEqual("00000000000000000000000000000000", res)

