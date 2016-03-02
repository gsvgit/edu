module Task16.Tests
open Task16
open Task15
open NUnit.Framework

[<Test>]
let ``main return 3`` () =
  let list1 = Cons(3,Cons(2,Cons(1,Empty))) 
  let res = main list1
  Assert.AreEqual(3, res)

[<Test>]
let ``main return 0`` () =
  let list1 = Empty 
  let res = main list1
  Assert.AreEqual(0, res)

[<Test>]
let ``main return 1`` () =
  let list1 = Cons(1,Empty) 
  let res = main list1
  Assert.AreEqual(1, res)
