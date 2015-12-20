module Task22.Tests

open Task15
open Task22
open NUnit.Framework

[<Test>]
let ``sort 1,2,3,4,5,6,7,8,9,10 return the same`` () =
  let inList = (Cons(1,Cons(2, Cons(3, Cons(4, Cons(5, Cons(6, Cons(7, Cons(8, Cons(9, Cons(10, Empty)))))))))))
  let res = sort inList
  Assert.AreEqual(inList, res)

[<Test>]
let ``sort 1,1,1,1,1 return the same`` () =
  let inList = (Cons(1,Cons(1, Cons(1, Cons(1, Cons(1, Empty))))))
  let res = sort inList
  Assert.AreEqual(inList, res)

[<Test>]
let ``sort 10,9,8,7,6,5,4,3,2,1 return 1,2,3,4,5,6,7,8,9,10`` () =
  let inList = (Cons(10, Cons(9, Cons(8, Cons(7, Cons(6, Cons(5, Cons(4, Cons(3, Cons(2, Cons(1, Empty)))))))))))
  let res = sort inList
  Assert.AreEqual((Cons(1, Cons(2, Cons(3, Cons(4, Cons(5, Cons(6, Cons(7, Cons(8, Cons(9, Cons(10, Empty))))))))))), res)

[<Test>]
let ``sort 69,7,75,83,81,85,63,32,24,48 return 7,24,32,48,63,69,75,81,83,85`` () =
  let inList = (Cons(69, Cons(7, Cons(75, Cons(83, Cons(81, Cons(85, Cons(63, Cons(32, Cons(24, Cons(48, Empty)))))))))))
  let res = sort inList
  Assert.AreEqual((Cons(7, Cons(24, Cons(32, Cons(48, Cons(63, Cons(69, Cons(75, Cons(81, Cons(83, Cons(85, Empty))))))))))), res)

[<Test>]
let ``sort Empty return Empty `` () =
  let inList = Empty
  let res = sort inList
  Assert.AreEqual(MyList<int>.Empty, res)