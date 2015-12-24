module Task31

open Task15
open Task30

let mult (num1: Num) (num2: Num) =
    match num1, num2 with
    | (sign1, ls1), (sign2, ls2) ->
    let produce ls1 ls2 =
        let mutable prod = 1, Cons(0, Empty)
        let mutable i = leftToRight ls2
        while (Task30.compare (cutOff(leftToRight i)) (Cons(0, Empty)) = 1) do
            match prod with
            | signp, tl ->
            prod <- (Task30.sum (1, tl) (1, ls1))
            i <- (increment 1 i -1 (Cons(1, Empty)) 0)
        prod

    match produce ls1 ls2 with
    | signp, tl -> (sign1 * sign2, tl)