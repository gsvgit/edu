module Task29.Test

open Task29
open NUnit.Framework

[<Test>]
let ``main 128 =`` () =
    let res = main 128L
    Assert.AreEqual("0000000000000000000000000000000000000000000000000000000010000000", res)

[<Test>]
let ``main 0 =`` () = 
    let res = main 0L
    Assert.AreEqual("0000000000000000000000000000000000000000000000000000000000000000", res)

[<Test>]
let ``main -32 =`` () = 
    let res = main -376L
    Assert.AreEqual("1111111111111111111111111111111111111111111111111111111010001000", res)

[<Test>]
let ``main -0 =`` () = 
    let res = main -0L
    Assert.AreEqual("0000000000000000000000000000000000000000000000000000000000000000", res)