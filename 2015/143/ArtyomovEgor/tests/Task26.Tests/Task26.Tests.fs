module Task26.Tests

open Task15
open Task26
open NUnit.Framework

[<Test>]
let ``Empty Tape`` () =
  let res = 
        main
        <| (Cons((Cons('H', Cons('e', Cons('l', Cons('l', Cons('o', Empty))))), Cons('B', Cons('y', Cons('e', Empty)))), Empty))
        <| Empty
  Assert.AreEqual((MyList.Empty: MyList<char>), res)

[<Test>]
let ``Empty rule`` () =
  let res = 
        main
        <| Empty
        <| Cons('H', Cons('e', Cons('l', Cons('l', Cons('o', Empty)))))
  Assert.AreEqual(Cons('H', Cons('e', Cons('l', Cons('l', Cons('o', Empty))))), res)

[<Test>]
let ``input Hello ruturn Bye`` () =
  let res = 
        main
        <| Cons((Cons('H', Cons('e', Cons('l', Cons('l', Cons('o', Empty))))), Cons('B', Cons('y', Cons('e', Empty)))), Empty)
        <| Cons('H', Cons('e', Cons('l', Cons('l', Cons('o', Empty)))))
  Assert.AreEqual(Cons('B', Cons('y', Cons('e', Empty))), res)

[<Test>]
let ``input Hello ruturn Bye (He to B, ll to y, o to e)`` () =
  let res = 
        main
        <| Cons((Cons('H', Cons('e', Empty)), Cons('B', Empty)), Cons((Cons('l', Cons('l', Empty)), Cons('y', Empty)), Cons((Cons('o', Empty), Cons('e', Empty)), Empty)))
        <| Cons('H', Cons('e', Cons('l', Cons('l', Cons('o', Empty)))))
  Assert.AreEqual(Cons('B', Cons('y', Cons('e', Empty))), res)

[<Test>]
let ``Rules dont apply (input=output)`` () =
  let res = 
        main
        <| Cons((Cons('H', Cons('e', Empty)), Cons('B', Empty)), Cons((Cons('l', Cons('l', Empty)), Cons('y', Empty)), Cons((Cons('o', Empty), Cons('e', Empty)), Empty)))
        <| Cons('1', Cons('2', Cons('2', Cons('4', Cons('5', Empty)))))
  Assert.AreEqual(Cons('1', Cons('2', Cons('2', Cons('4', Cons('5', Empty))))), res)