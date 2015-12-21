module Task32.Tests

open NUnit.Framework
open Task32
open Task31
open Task30
open Task15

[<Test>]
let ``Test fibfrom8 num 8`` () =
  let res = fibFrom8(1, Cons(8, Empty))
  Assert.AreEqual((1, Cons (2, Cons (1, Empty))), res)
[<Test>]
let ``Test fibfrom9 num 8`` () =
  let res = fibFrom9(1, Cons(8, Empty))
  Assert.AreEqual((1, Cons (2, Cons (1, Empty))), res)
[<Test>]
let ``Test fibfrom10 num 8`` () =
  let res = fibFrom10(1, Cons(8, Empty))
  Assert.AreEqual((1, Cons (2, Cons (1, Empty))), res)
[<Test>]
let ``Test fibfrom11 num 8`` () =
  let res = fibFrom11(1, Cons(8, Empty))
  Assert.AreEqual((1, Cons (2, Cons (1, Empty))), res)
[<Test>]
let ``Test on 2`` () =
  let res = fibFrom12(1, Cons(8, Empty))
  Assert.AreEqual((1, Cons (2, Cons (1, Empty))), res)
[<Test>]
let ``Test on 10 fibfrom8`` () =
  let res = fibFrom8(1, Cons(1, Cons(0, Empty)))
  Assert.AreEqual((1, Cons (5,Cons (5,Empty))), res)
[<Test>]
let ``Test on 10 fibfrom9`` () =
  let res = fibFrom9(1, Cons(1, Cons(0, Empty)))
  Assert.AreEqual((1, Cons (5,Cons (5,Empty))), res)
[<Test>]
let ``Test on 10 fibfrom10`` () =
  let res = fibFrom10(1, Cons(1, Cons(0, Empty)))
  Assert.AreEqual((1, Cons (5,Cons (5,Empty))), res)
[<Test>]
let ``Test on 10 fibfrom11`` () =
  let res = fibFrom11(1, Cons(1, Cons(0, Empty)))
  Assert.AreEqual((1, Cons (5,Cons (5,Empty))), res)
[<Test>]
let ``Test on 16 fibfrom12`` () =
  let res = fibFrom12(1, Cons(1, Cons(6, Empty)))
  Assert.AreEqual((1, Cons (9,Cons (8, Cons(7, Empty)))), res)
[<Test>]
let ``Test on 10 fibfrom13`` () =
  let res = fibFrom13 10
  Assert.AreEqual([|(1, Cons (1,Empty)); (1, Cons (1,Empty)); (1, Cons (2,Empty)); (1, Cons (3,Empty)); (1, Cons (5,Empty)); (1, Cons (8,Empty)); (1, Cons (1,Cons (3,Empty))); (1, Cons (2,Cons (1,Empty))); (1, Cons (3,Cons (4,Empty))); (1, Cons (5,Cons (5,Empty)))|], res)
[<Test>]
let ``Check inInt`` () =
  let res = inInt (-1, Cons(1, Cons(2, Empty)))
  Assert.AreEqual(-12, res)
[<Test>]
let ``Check fromInt`` () =
  let res = fromInt 25
  Assert.AreEqual ((1, Cons(2, Cons(5, Empty))), res)