module Task32.Tests

open Task15
open Task30
open Task31
open Task32
open NUnit.Framework

[<Test>]
let ``Task32 fibRec 2 return 1`` () =
    let res = fibRec 2
    Assert.AreEqual("1", NumToString res)

[<Test>]
let ``Task32 fibRec 5 return 5`` () =
    let res = fibRec 5
    Assert.AreEqual("5" ,NumToString res)

[<Test>]
let ``Task32 fibRec 10 return 55`` () =
    let res = fibRec 10
    Assert.AreEqual("55", NumToString res)

[<Test>]
let ``Task32 fibIt 2 return 1`` () =
    let res = fibIt 2
    Assert.AreEqual("1", NumToString res)

[<Test>]
let ``Task32 fibIt 5 return 5`` () =
    let res = fibIt 5
    Assert.AreEqual("5" ,NumToString res)

[<Test>]
let ``Task32 fibIt 10 return 55`` () =
    let res = fibIt 10
    Assert.AreEqual("55", NumToString res)

[<Test>]
let ``Task32 fibIt2 2 return 1`` () =
    let res = fibIt2 2
    Assert.AreEqual("1", NumToString res)

[<Test>]
let ``Task32 fibIt2 5 return 5`` () =
    let res = fibIt2 5
    Assert.AreEqual("5" ,NumToString res)

[<Test>]
let ``Task32 fibIt2 10 return 55`` () =
    let res = fibIt2 10
    Assert.AreEqual("55", NumToString res)

    
[<Test>]
let ``Task32 fibMat 2 return 1`` () =
    let res = fibMat 2
    Assert.AreEqual("2", NumToString res)

[<Test>]
let ``Task32 fibMat 5 return 5`` () =
    let res = fibMat 5
    Assert.AreEqual("8" ,NumToString res)

[<Test>]
let ``Task32 fibMat 10 return 55`` () =
    let res = fibMat 10
    Assert.AreEqual("89", NumToString res)

[<Test>]
let ``Task32 fibMat2 2 return 1`` () =
    let res = fibMat2 2
    Assert.AreEqual("2", NumToString res)

[<Test>]
let ``Task32 fibMat2 5 return 5`` () =
    let res = fibMat2 5
    Assert.AreEqual("8" ,NumToString res)

[<Test>]
let ``Task32 fibMat2 10 return 55`` () =
    let res = fibMat2 10
    Assert.AreEqual("89", NumToString res)

[<Test>]
let ``Task 13 main 7 = [|0;1;1;2;3;5;8;13|]`` () = 
    let res = Array.init(8) (fun i -> NumToString (fibArr 7).[i])
    Assert.AreEqual([|"0"; "1"; "1"; "2"; "3"; "5"; "8"; "13"|], res)
