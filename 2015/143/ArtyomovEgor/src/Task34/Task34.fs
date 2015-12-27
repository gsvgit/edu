module Task34

open System.IO
open Task26
open Task15

let readLines (filePath:string) = seq {
    use sr = new StreamReader (filePath)
    while not sr.EndOfStream do
        yield sr.ReadLine ()
}

printfn "%A" <| readLines "C:\Users\mercuryjuice\Desktop\New Text Document.txt"
let stay = System.Console.ReadKey(true)