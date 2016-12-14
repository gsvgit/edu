module Task22.Tests

open Task15
open Task22
open NUnit.Framework

[<Test>]
let ``Task 22 main [2, 9, 4, 6, 5] = [2, 4, 5, 6, 9]`` () =
    let lst = Cons(5, Empty)
    let res = main ((((lst.add 6).add 4). add 9). add 2)
    Assert.AreEqual(Cons(2, Cons(4, Cons(5, Cons(6, Cons(9, Empty))))), res)

[<Test>]
let ``Task 22 main [] = []`` () =
    let res = main(Empty)
    Assert.AreEqual(MyList<int>.Empty, res)

[<Test>]
let ``Task 22 main [6, 6, 7] = [6, 6, 7]`` () =
    let lst = Cons(7, Empty)
    let res = main ((lst.add 6).add 6)
    Assert.AreEqual(Cons(6, Cons(6, Cons(7, Empty))), res)

[<Test>]
let ``Task 22 main [1, 6, 7, 5] = [1, 5, 6, 7]`` () =
    let lst = Cons(5, Empty)
    let res = main (((lst.add 7).add 6).add 1)
    Assert.AreEqual(Cons(1, Cons(5, Cons(6, Cons(7, Empty)))), res)