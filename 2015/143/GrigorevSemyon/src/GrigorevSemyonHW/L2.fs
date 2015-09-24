module L2

[<Struct>]
type MyStruct =
 val fld1: int
 val fld2: string
 new (f1,f2) = {fld1 = f1 + 1; fld2 = f2}

let f () =
    let mStruct = new MyStruct(1,"sdsd")
    mStruct.fld1

let arr = [|1; 2; 3|]
let lst = [1; 2; 3]
lst.Head + 1 
|> printfn "Head: %A"

printfn "Head: %A" (lst.Head + 1)

lst.Tail |> printfn "Tail: %A"
