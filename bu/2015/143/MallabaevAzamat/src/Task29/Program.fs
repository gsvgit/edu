// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

let rec long2bits l =
    if l = 0L then ""
    else (long2bits (l / 2L)) + ((l % 2L) |> string)

let main inum = printf "%s" ((long2bits inum).PadLeft(64, '0'))

[<EntryPoint>]
let entry argv = 
    printf "Введите int64\n"
    main (System.Console.ReadLine() |> int64)
    0 // return an integer exit code

