// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
module Task21

open Task15

type Opt<'a> =
    | Sth of 'a
    | Nth

let rec get lst i =
    if i >= 0 then
        match lst with
        | Empty -> Nth
        | Smth (x, xs) -> if i = 0 then Sth x else get xs (i - 1)
    else Nth

let rec set lst i v =
    if i >= 0 then
        match lst with
        | Empty -> lst
        | Smth (x, xs) -> if i = 0 then Smth (v, xs) else Smth (x, set xs (i - 1) v)
    else lst

let swap lst i j =
    match get lst i, get lst j with
    | Sth x, Sth y -> set (set lst i y) j x
    | _, _ -> lst

let length lst = foldU lst 0 (fun x -> x + 1)

let sort lst =
    let mutable l = lst
    for i in 0..(length lst - 1) do
        for j in (i + 1)..(length lst - 1) do
            if get l i > get l j then
                l <- swap l i j
            else ()
    l

let main lst = sort lst

[<EntryPoint>]
let entry argv = 
    let lst = Smth (10, Smth (12, Smth (5, Smth (15, Empty))))
    printfn "main (%A) = %A" lst (main lst)
    0 // return an integer exit code

