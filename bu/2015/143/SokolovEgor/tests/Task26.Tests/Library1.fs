module Task26.Tests

open Task15
open Task26
open NUnit.Framework

[<Test>]
let ``test 1 `` () = 
  let res = interpr (Cons((Cons('a', Cons('b', Empty)), Cons('c', Cons('c', Empty))), Cons((Cons('b', Empty), Cons('a', Cons('a', Empty))), Empty))) (Cons('a', Cons('a', Cons('b', Cons('c', Empty)))))
  Assert.AreEqual((Cons('a', Cons('c', Cons('c', Cons('c', Empty))))), res)
[<Test>]
let ``test 2 `` () =
  let res = interpr (Cons((Cons('a', Empty), Cons('b', Cons('b', Empty))), Cons((Cons('b', Empty), Cons('c', Empty)), Empty))) (Cons('a', Cons('a', Cons('b', Cons('c', Empty)))))
  Assert.AreEqual((Cons ('c',Cons ('c',Cons ('c',Cons ('c',Cons ('c',Cons ('c',Empty))))))), res)