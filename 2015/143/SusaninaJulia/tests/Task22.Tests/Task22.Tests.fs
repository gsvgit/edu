module Task22.Tests
open Task22
open Task15
open NUnit.Framework

[<Test>]
let ``main Cons(4, Cons(3, Cons(2, Cons(1, Empty)))) returns Cons(1, Cons(2, Cons(3, Cons(4, Empty))))`` () = 
    let res = main (Cons(4, Cons(3, Cons(2, Cons(1, Empty)))))
    Assert.AreEqual(Cons(1, Cons(2, Cons(3, Cons(4, Empty)))), res)

[<Test>]
let ``main Cons(4, Cons(4, Cons(4, Cons(4, Empty)))) returns Cons(4, Cons(4, Cons(4, Cons(4, Empty))))`` () = 
    let res = main (Cons(4, Cons(4, Cons(4, Cons(4, Empty)))))
    Assert.AreEqual(Cons(4, Cons(4, Cons(4, Cons(4, Empty)))), res)

[<Test>]
let ``main (Cons(1, Cons(2, Cons(3, Cons(4, Empty)))) returns Cons(1, Cons(2, Cons(3, Cons(4, Empty)))`` () = 
    let res = main (Cons(1, Cons(2, Cons(3, Cons(4, Empty)))))
    Assert.AreEqual(Cons(1, Cons(2, Cons(3, Cons(4, Empty)))), res)

[<Test>]
let ``main Empty = Empty`` () = 
    let res = main Empty
    Assert.AreEqual(MyList<int>.Empty, res)