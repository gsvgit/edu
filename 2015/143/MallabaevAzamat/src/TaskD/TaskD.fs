module TaskD

let (>*>) (a:int array array) (b:int array array) =
  [|[|a.[0].[0] * b.[0].[0] + a.[1].[0] * b.[0].[1];
      a.[0].[0] * b.[1].[0] + a.[1].[0] * b.[1].[1]|];
    [|a.[0].[1] * b.[0].[0] + a.[1].[1] * b.[0].[1];
      a.[0].[1] * b.[1].[0] + a.[1].[1] * b.[1].[1]|]|]

let rec sqrt (a:int array array) = a >*> a

let rec (>^>) (a:int array array) n =
  if n = 1 then a
  else if n % 2 = 0 then (sqrt a) >^> n / 2
  else a >*> (a >^> (n - 1))

let fib n =
  if n = 0 then 0
  else if n > 0 then ([|[|1; 1|];
                        [|1; 0|]|] >^> n).[0].[1]
  else if (-n) % 2 = 1 then ([|[|1; 1|];
                               [|1; 0|]|] >^> -n).[0].[1]
  else -([|[|1; 1|];
           [|1; 0|]|] >^> -n).[0].[1]

let main n =
  if n = 0 then [|0|]
  else if n > 0 then [|for i in 0..n -> fib i|]
  else [|for i in 0..-n -> fib -i|]