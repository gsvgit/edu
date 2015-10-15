module Task18.Tests
open NUnit.Framework
open Task15
open Task18
      
[<Test>]                       
let ``toMyString "" returned Nil`` () =
  let result = toMyString ""
  printfn "%A" result
  Assert.True(Nil == result)

[<Test>]
let ``toMyString "s" returned Cons('s', Nil)`` () =
  let result = toMyString "s"
  printfn "%A" result
  Assert.True((Cons('s', Nil) == result))

[<Test>]
let ``toMyString "42" returned Cons('2', Cons('4'. Nil))`` () =
  let result = toMyString "42"
  printfn "%A" result
  Assert.True(Cons('4', Cons('2', Nil)) == result)
