module TaskB

type num = int
type 'a simmat = 'a array

let rec mul (a:num simmat) (n:num) =
  if n = 1 then 1
  else if n = 2 then 1
  else
    for i in 3..n do
      a.[2] <- a.[1]
      a.[1] <- a.[0]
      a.[0] <- a.[1] + a.[2]
    a.[0]

let main n =
  if n = 0 then 0
  else if n > 0 then (mul [|1; 1; 0|] n)
  else if (-n) % 2 = 1 then (mul [|1; 1; 0|] -n)
  else -(mul [|1; 1; 0|] -n)

[<EntryPoint>]
let entry args =
  printfn "%i" (main (int (System.Console.ReadLine())))
  ignore <| System.Console.ReadKey()
  0
