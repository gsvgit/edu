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
  printf "%A" res
  Assert.AreEqual((1, Cons (2, Cons (1, Empty))), res)