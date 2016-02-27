module Task18.Tests

open NUnit.Framework
open Task15
open Task18

[<Test>]
let ``toMyString "hello" returns Smth ('h', Smth ('e', Smth ('l', Smth ('l', Smth ('o', Empty)))))`` () =
    let result = toMyString "hello"
    printf "toMyString \"hello\" = %A" result
    Assert.AreEqual(Smth ('h', (Smth ('e', (Smth ('l', (Smth ('l', (Smth ('o', Empty))))))))), result)

[<Test>]
let ``toMyString "h" returns Smth ('h', Empty)`` () =
    let result = toMyString "h"
    printf "toMyString \"h\" = %A" result
    Assert.AreEqual(Smth ('h', Empty), result)

[<Test>]
let ``toMyString "" returns Empty`` () =
    let result = toMyString ""
    printf "toMyString \"\" = %A" result
    Assert.IsTrue(match result with | Empty -> true | _ -> false)

