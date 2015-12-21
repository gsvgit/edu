module Task26.Tests

open Task26
open Task15
open NUnit.Framework

[<Test>]
let ``1`` () = 
    let res = 
        interpretator 
        <| (Cons((Cons('a', Cons('a', Empty)), Cons('b', Cons('b', Empty))), Cons((Cons('b', Empty), Cons('a', Cons('a', Empty))), Empty))) 
        <| (Cons('a', Cons('a', Cons('b', Cons('c', Empty)))))
    Assert.AreEqual((Cons('a', Cons('a', Cons('a', Cons('a', Cons('a', Cons('a', Cons('c', Empty)))))))), res)

[<Test>]
let ``2`` () = 
    let res = 
        interpretator 
        <| Empty 
        <| (Cons('a', Cons('a', Cons('b', Cons('c', Empty)))))
    Assert.AreEqual((Cons('a', Cons('a', Cons('b', Cons('c', Empty))))), res)

[<Test>]
let ``3`` () = 
    let res = 
        interpretator 
        <| (Cons((Cons('a', Cons('b', Empty)), Cons('b', Cons('b', Empty))), Cons((Cons('b', Cons('a', Empty)), Cons('a', Cons('a', Empty))), Empty)))
        <| (Cons('b', Cons('a', Cons('b', Cons('b', Cons('a', Cons('a', Empty)))))))
    Assert.AreEqual((Cons('b', Cons('b', Cons('b', Cons('a', Cons('a', Cons('a', Empty))))))), res)