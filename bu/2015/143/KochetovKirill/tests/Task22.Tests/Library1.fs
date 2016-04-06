module Task22.Tests
open Task22
open Task15
open NUnit.Framework

[<Test>]
let ``main Cons(4, Cons(3, Cons(2, Cons(1, Empty)))) = Cons(1, Cons(2, Cons(3, Cons(4, Empty))))`` () = 
    let res = main (Cons(4, Cons(3, Cons(2, Cons(1, Empty)))))
    Assert.AreEqual(Cons(1, Cons(2, Cons(3, Cons(4, Empty)))), res)

[<Test>]
let ``main (Empty.add(1).add(3).add(2).add(5)) = Cons(1, Cons(2, Cons(3, Cons(5, Empty))))`` () = 
    let res = main (Empty.add(1).add(3).add(2).add(5))
    Assert.AreEqual(Cons(1, Cons(2, Cons(3, Cons(5, Empty)))), res)

[<Test>]
let ``main (Empty.add(1).add(1).add(3).add(1)) = Cons(1, Cons(1, Cons(1, Cons(3, Empty))))`` () = 
    let res = main (Empty.add(1).add(1).add(3).add(1))
    Assert.AreEqual(Cons(1, Cons(1, Cons(1, Cons(3, Empty)))), res)

[<Test>]
let ``main Empty = Empty`` () = 
    let res = main Empty
    Assert.AreEqual(MyList<int>.Empty, res)
