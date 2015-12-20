module Task28.Tests

open NUnit.Framework
open Task28

[<Test>]
let ``Task28 : main -2 147 483 648 returns 10000000000000000000000000000000`` () =
  let res = main -2147483648
  Assert.AreEqual("10000000000000000000000000000000" |> ignore, res)

[<Test>]
let ``Task28 : main 0 returns 00000000000000000000000000000000`` () =
  let res = main 0
  Assert.AreEqual("00000000000000000000000000000000" |> ignore, res)

[<Test>]
let ``Task28 : main 1 returns 00000000000000000000000000000001`` () =
  let res = main 1
  Assert.AreEqual("00000000000000000000000000000001" |> ignore, res)
