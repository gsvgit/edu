module TaskC

type num = int
type 'a simmat = 'a array

let rec (>^>) (a:num simmat) n =
  let i = ref n
  let ops = ref []
  while !i <> 1 do
    if !i % 2 = 1 then
      ops := true :: !ops
      i := !i - 1
    else
      ops := false :: !ops
      i := !i / 2
  for it in !ops do
    if it then
      a.[2] <- a.[1]
      a.[1] <- a.[0]
      a.[0] <- a.[1] + a.[2]
    else
      let keep = a.[0] + a.[2]
      a.[2] <- a.[2] * a.[2] + a.[1] * a.[1]
      a.[0] <- a.[0] * a.[0] + a.[1] * a.[1]
      a.[1] <- keep * a.[1]
  a.[1]

let main n =
  if n = 0 then 0
  else
    let a = [|1; 1; 0|]
    if n > 0 then
      (a >^> n)
    else if (-n) % 2 = 1 then
      (a >^> -n)
    else
      -(a >^> -n)

[<EntryPoint>]
let entry args =
  printfn "%i" (main (int (System.Console.ReadLine())))
  ignore <| System.Console.ReadKey()
  0