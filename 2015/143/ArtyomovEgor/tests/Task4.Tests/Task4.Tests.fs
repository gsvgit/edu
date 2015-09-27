﻿module Task4.Tests

open Task4
open NUnit.Framework

[<Test>]
let ``main [||] 0 return [||]`` () =
  let res = main [||] 0
  Assert.AreEqual([||], res)

[<Test>]
let ``main [|0; 1; 2; 3; 4; 5; 6; 7; 8; 9; 10|] 5 return [|0; 1; 2; 3; 4; 5|]`` () =
  let res = main [|0; 1; 2; 3; 4; 5; 6; 7; 8; 9; 10|] 5
  Assert.AreEqual([|0; 1; 2; 3; 4; 5|], res)

[<Test>]
let ``main [|10; 9; 8; 7; 6; 5; 4; 3; 2; 1; 0|] 5 return [|5; 6; 7; 8; 9; 10|]`` () =
  let res = main [|10; 9; 8; 7; 6; 5; 4; 3; 2; 1; 0|] 5
  Assert.AreEqual([|5; 6; 7; 8; 9; 10|], res)

[<Test>]
let ``main [|256; 100; 853 ; 781; 1256|] 1 return [||]`` () =
  let res = main [|256; 100; 853 ; 781; 1256|] 1
  Assert.AreEqual([||], res)