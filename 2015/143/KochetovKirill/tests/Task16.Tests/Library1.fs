module Task16.Tests

open Task16
open Task15
open NUnit.Framework

[<Test>]
let ``main [2, 3, 4] = 3`` () = 
  let lst = Cons(4, Empty)
  let res = main ((lst.add 3).add 2)
  Assert.AreEqual(3, res)

[<Test>]
let ``main [true, false, true] = 3`` () = 
  let lst = Cons(true, Empty)
  let res = main ((lst.add false).add true)
  Assert.AreEqual(3, res)

[<Test>]
let ``main [svn, trt, pr] = 3`` () = 
  let lst = Cons("pr", Empty)
  let res = main ((lst.add "trt").add "svn")
  Assert.AreEqual(3, res)

[<Test>]
let ``main [] = 0`` () = 
  let lst = Empty
  let res = main lst
  Assert.AreEqual(0 ,res)
