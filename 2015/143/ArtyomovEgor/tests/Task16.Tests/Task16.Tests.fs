module Task16.Tests

open Task15
open Task16
open NUnit.Framework

[<Test>]
let ``len (Cons(1,Cons(2, Empty))) return 2`` () =
  let lst = (Cons(1,Cons(2, Empty)))
  let res = main lst
  Assert.AreEqual(2, res)

[<Test>]
let ``len List.Empty return 0`` () =
  let lst = MyList.Empty
  let res = main lst
  Assert.AreEqual(0, res)

[<Test>]
let ``len (Cons(1,Cons(2, (3,Cons(4, Empty))))) return 4`` () =
  let lst = (Cons(1,Cons(2, Cons(3,Cons(4, Empty)))))
  let res = main lst
  Assert.AreEqual(4, res)