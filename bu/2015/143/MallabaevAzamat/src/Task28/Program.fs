// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

let rec int2bits l =
    if l = 0 then ""
    else (int2bits (l / 2)) + ((l % 2) |> string)

let main inum = printf "%s" ((int2bits inum).PadLeft(32, '0'))

[<EntryPoint>]
let entry argv = 
    printf "Введите int\n"
    main (System.Console.ReadLine() |> int)
    0 // return an integer exit code

