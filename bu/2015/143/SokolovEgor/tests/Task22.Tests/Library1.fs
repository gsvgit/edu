module Task22.Tests
open Task15
open Task16
open Task22
open NUnit.Framework

[<Test>]
let ``2 List`` () =
  let res = main(Cons(5,Cons(2, Empty)))
  Assert.AreEqual(res, Cons(2, Cons(5, Empty)))

[<Test>]
let ``0 List`` () =
  let res = main(Empty)
  Assert.AreEqual(res, MyList<int>.Empty)

[<Test>]
let ``1 List`` () =
  let res = main(Cons(2, Empty))
  Assert.AreEqual(res, Cons(2, Empty))

[<Test>]
let ``6 List`` () =
    let res = main(Cons(5, Cons(6, Cons(7, Cons(1, Cons(2, Empty))))))
    Assert.AreEqual(res, Cons(1, Cons(2, Cons(5, Cons(6, Cons(7, Empty))))))

