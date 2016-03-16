module Tests

open Task15
open Task21
open System
open NUnit.Framework

[<Test>]
let ``Task21:main Empty = Empty)``() =
    let arg = Empty
    let result = main arg
    printf "main %A = %A" arg result
    Assert.IsTrue(match result with | Empty -> true | _ -> false)

[<Test>]
let ``Task21:main (Smth (12, Smth (15, Smth (31, Smth (42, Empty))))) = Smth (12, Smth (15, Smth (31, Smth (42, Empty))))``() =
    let arg = Smth (12, Smth (15, Smth (31, Smth (42, Empty))))
    let result = main arg
    printf "main %A = %A" arg result
    Assert.AreEqual(Smth (12, Smth (15, Smth (31, Smth (42, Empty)))), result)

[<Test>]
let ``Task21:main (Smth (15, Smth (12, Smth (42, Smth (31, Empty))))) = Smth (12, Smth (15, Smth (31, Smth (42, Empty))))``() =
    let arg = (Smth (15, Smth (12, Smth (42, Smth (31, Empty)))))
    let result = main arg
    printf "main %A = %A" arg result
    Assert.AreEqual(Smth (12, Smth (15, Smth (31, Smth (42, Empty)))), result)

