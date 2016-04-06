module Task21.Tests

open Task15
open Task21
open NUnit.Framework

[<Test>]
let ``Task21:main (Cons (3,Cons (1,Cons (2,Cons (5,Cons (4,Empty)))))) returns (Cons (1,Cons (2,Cons (3,Cons (4,Cons (5,Empty))))))`` () =
  let result = main (Cons (3,Cons (1,Cons (2,Cons (5,Cons (4,Empty))))))
  printfn "%A" result
  Assert.AreEqual((Cons (1,Cons (2,Cons (3,Cons (4,Cons (5,Empty)))))), result)

[<Test>]
let ``Task21:main Empty returns Empty`` () =
  let result = main Empty
  printfn "%A" result
  Assert.AreEqual((Empty : MyList<int>), result)
  
[<Test>]
let ``Task21:main (Cons(3,Empty)) returns (Cons(3,Empty))`` () =
  let result = main (Cons(3,Empty)) 
  printfn "%A" result
  Assert.AreEqual((Cons(3,Empty)), result)