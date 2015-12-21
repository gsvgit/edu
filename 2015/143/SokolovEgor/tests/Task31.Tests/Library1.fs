module Task31.Tests

open NUnit.Framework
open Task31
open Task30
open Task15

[<Test>]
let ``input -20 * 31`` () =
  let res = Task31.mult (-1, Cons(2, Cons(0, Empty))) (1, Cons(3, Cons(1, Empty)))
  Assert.AreEqual((-1, Cons (6, Cons (2, Cons (0, Empty)))), res)

[<Test>]
let ``input 20 * 31`` () =
  let res = Task31.mult (1, Cons(2, Cons(0, Empty))) (1, Cons(3, Cons(1, Empty)))
  Assert.AreEqual((1, Cons (6, Cons (2, Cons (0, Empty)))), res)


[<Test>]
let ``input 20 * (-600)`` () =
  let res = Task31.mult (1, Cons(2, Cons(0, Empty))) (-1, Cons(6, Cons(0, Cons(0, Empty))))
  Assert.AreEqual((-1, Cons (1,Cons (2,Cons (0,Cons (0,Cons (0,Empty)))))), res)