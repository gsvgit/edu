module Task26.Tests

open Task26
open Task15
open NUnit.Framework

[<Test>]
let ``te`` () = 
    let res = interpretator (Cons((Cons('a', Cons('a', Empty)), Cons('b', Cons('b', Empty))), Cons((Cons('b', Empty), Cons('a', Cons('a', Empty))), Empty))) (Cons('a', Cons('a', Cons('b', Cons('c', Empty)))))
    Assert.AreEqual((Cons('a', Cons('a', Cons('a', Cons('a', Cons('a', Cons('a', Cons('c', Empty)))))))), res)