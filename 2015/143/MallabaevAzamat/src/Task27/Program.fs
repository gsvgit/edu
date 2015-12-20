// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

let rec long2bits l =
    if l = 0L then ""
    else (long2bits (l / 2L)) + ((l % 2L) |> string)

let main fnum = printf "%s" ((long2bits (System.BitConverter.DoubleToInt64Bits fnum)).PadLeft(64, '0'))

[<EntryPoint>]
let entry argv =
    printf "Введите float\n"
    main (System.Double.Parse(System.Console.ReadLine()))
    0 // return an integer exit code

