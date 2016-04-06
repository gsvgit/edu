module Task30.Tests

open Task30
open Task15
open NUnit.Framework

[<Test>]
let ``921 + 231 = 1152`` () = 
    let res = sum (1, Cons(1, Cons(2, Cons(9, Empty)))) (1, Cons(1, Cons(3, Cons(2, Empty))))
    Assert.AreEqual((1, Cons(2, Cons(5, Cons(1, Cons(1, Empty))))), res)

[<Test>]
let ``967 + 358 = 1325`` () = 
    let res = sum (1, Cons(7, Cons(6, Cons(9, Empty)))) (1, Cons(8, Cons(5, Cons(3, Empty))))
    Assert.AreEqual((1, Cons(5, Cons(2, Cons(3, Cons(1, Empty))))), res)

[<Test>]
let ``1125 - 1105 = 20`` () = 
    let res = sum (1, Cons(5, Cons(2, Cons(1, Cons(1, Empty))))) (-1, Cons(5, Cons(0, Cons(1, Cons(1, Empty)))))
    Assert.AreEqual((1, Cons(0, Cons(2, Empty))), res)

[<Test>]
let ``1 - 1 = 0`` () = 
    let res = sum (1, Cons(1, Empty)) (-1, Cons(1, Empty))
    Assert.AreEqual((1, Cons(0, Empty)), res)