module Task26.Tests

open Task26
open NUnit.Framework

[<Test>]
let ``hello world`` () =
    let result = interpretator rules "hello world"
    printfn "%A" result
    Assert.AreEqual(result, "0110100001100101011011000110110001101111001000000111011101101111011100100110110001100100")

[<Test>]
let ``do nothing`` () =
    let result = interpretator rules "Код"
    printfn "%A" result
    Assert.AreEqual(result, "Код")