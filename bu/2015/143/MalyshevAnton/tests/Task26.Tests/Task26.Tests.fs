module Task26.Tests

open Task26
open NUnit.Framework

[<Test>]
let ``interpret test1`` () =
    let result = interpretator "ab->c;c->g;d->f;" "abdabdab"
    printfn "%A" result
    Assert.AreEqual(result, "gfgfg")

[<Test>]
let ``interpret test2`` () =
    let result = interpretator "1->0;2->3;0->5;" "102301"
    printfn "%A" result
    Assert.AreEqual(result, "553355")