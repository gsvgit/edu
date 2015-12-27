module Task32.Tests

open NUnit.Framework
open Task32
open Task31
open Task30
open Task15

[<Test>]
let ``task8FibN 9 returns (1, Cons (3, Cons (4, Empty)))`` () =
  let res = task8Long (1, Cons(9, Empty))
  Assert.AreEqual((1, Cons (3, Cons (4, Empty))), res)

[<Test>]
let ``task9FibN 9 returns (1, Cons (3, Cons (4, Empty)))`` () =
  let res = task9Long (1, Cons(9, Empty))
  Assert.AreEqual((1, Cons (3, Cons (4, Empty))), res)

[<Test>]
let ``task10FibN 9 returns (1, Cons (3, Cons (4, Empty)))`` () =
  let res = task10Long (1, Cons(9, Empty))
  Assert.AreEqual((1, Cons (3, Cons (4, Empty))), res)

[<Test>]
let ``task11FibN 9 returns (1, Cons (3, Cons (4, Empty)))`` () =
  let res = task11Long (1, Cons(9, Empty))
  Assert.AreEqual((1, Cons (3, Cons (4, Empty))), res)

[<Test>]
let ``task12FibN 9 returns (1, Cons (3, Cons (4, Empty)))`` () =
  let res = task12Long (1, Cons(9, Empty))
  Assert.AreEqual((1, Cons (3, Cons (4, Empty))), res)

[<Test>]
let ``task13FibN 9`` () =
  let res = task13Long (1, Cons(9, Empty))
  Assert.AreEqual([|(1, Cons (1,Empty)); (1, Cons (1,Empty)); (1, Cons (2,Empty)); (1, Cons (3,Empty)); (1, Cons (5,Empty)); (1, Cons (8,Empty)); (1, Cons (1,Cons (3,Empty))); (1, Cons (2,Cons (1,Empty))); (1, Cons (3,Cons (4,Empty)))|], res)
