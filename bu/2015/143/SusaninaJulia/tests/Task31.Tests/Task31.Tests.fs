module Task31.Tests

open NUnit.Framework
open Task31
open Task30
open Task15

[<Test>]
let ``Task31 58 * 190`` () =
  let res = multiplication (1, Cons(5, Cons(8, Empty))) (1, Cons(1, Cons(9, Cons(0, Empty))))
  Assert.AreEqual ((1, Cons (1, Cons (1, Cons (0, Cons(2, Cons(0, Empty)))))), res)

[<Test>]
let ``Task31 40 * -567`` () =
  let res = multiplication (1, Cons(4, Cons(0, Empty))) (-1, Cons(5, Cons(6, Cons(7, Empty))))
  Assert.AreEqual((-1, Cons (2,Cons (2,Cons (6,Cons (8,Cons (0,Empty)))))), res)

[<Test>]
let ``Task31 -13 * 29`` () =
  let res = multiplication (1, Cons(2, Cons(9, Empty))) (-1, Cons(1, Cons(3, Empty)))
  Assert.AreEqual((-1, Cons (3, Cons (7, Cons (7, Empty)))), res)

[<Test>]
let ``Task31 0 * 900`` () =
  let res = multiplication (1, Cons(0, Empty)) (1, Cons(9, Cons(0, Cons(0, Empty))))
  Assert.AreEqual((1, Cons (0,Empty)), res)
  
[<Test>]
let ``Task31 0015 * -360`` () =
  let res = multiplication (1, Cons(0, Cons(0, Cons(1, Cons(5, Empty))))) (-1, Cons(3, Cons(6, Cons(0, Empty))))
  Assert.AreEqual((-1, Cons (5,Cons (4,Cons (0,Cons (0, Empty))))), res)