// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

type msg =
    | Data of array<int>
    | End

let fib x =
    let rec fib n =
        if n >= 2
        then fib (n - 1) + fib (n - 2)
        else 1
    fib x

let a1 = [|0..40|]

[<EntryPoint>]
let main argv = 
    let p1 () =
        a1
        |> Array.Parallel.map fib
        |> printfn "%A"
    
    let p2 () =
        let cnt = 10
        let f i (buf:array<_>) = fun () -> a1 |> Array.map fib |> fun a -> buf.[i] <- a
        let f i (buf:ResizeArray<_>) = fun () -> a1 |> Array.map fib |> buf.Add
        let th i buf = System.Threading.Thread(f i buf)
        let buf = 
            new ResizeArray<_>()
            //Array.zeroCreate (cnt + 1)        
        let ths = [|for i in 0..cnt -> th i buf|]
        ths |> Array.iter (fun th -> th.Start())
        ths |> Array.iter (fun th -> th.Join())

        //System.Threading.Thread.Sleep(20000)

        buf
        |> Array.ofSeq
        |> Array.iter (printfn "%A")

    let p3 () =
        let flg = ref false
        let agent name = 
            MailboxProcessor.Start(fun inbox ->
                let rec loop n =
                    async {
                            let! msg = inbox.Receive()
                            match msg with
                            | Data a -> 
                                printfn "%A::%A" name a
                                return! loop n
                            | End -> flg := true
                            }
                loop 0)

        let a1 = agent("name1")
        let a2 = agent("name2")
        for i in 0..100 do
            a1.Post (Data [|0..i|])
            a2.Post (Data [|0..i|])

        a1.Post End
        a2.Post End

        while not !flg do ()

    p3()
    0 // return an integer exit code
