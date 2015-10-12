module Task13.Tests

open Task13
open NUnit.Framework

[<Test>]
let ``fibArr 1 return [|1|]`` () =
  let res = fibArr 1
  Assert.AreEqual([|1|], res)

[<Test>]
let ``fibArr 6 return [|1; 1; 2; 3; 5; 8|]`` () =
  let res = fibArr 6
  Assert.AreEqual([|1; 1; 2; 3; 5; 8|], res)

[<Test>]
let ``fibArr 20 return [|1; 1; 2; 3; 5; 8; 13; 21; 34; 55; 89; 144; 233; 377; 610; 987; 1597; 2584; 4181; 6765|]`` () =
  let res = fibArr 20
  Assert.AreEqual([|1; 1; 2; 3; 5; 8; 13; 21; 34; 55; 89; 144; 233; 377; 610; 987; 1597; 2584; 4181; 6765|], res)