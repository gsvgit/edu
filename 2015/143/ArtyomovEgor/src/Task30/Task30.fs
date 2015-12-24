module Task30

open Task15

type Num =
    int * Task15.MyList<int>

let rec compare (lst1: MyList<int>) (lst2: MyList<int>) =
    if 
        lst1.length() > lst2.length()
    then 
        1
    elif 
        lst1.length() < lst2.length()
    then 
        2
    else
        match lst1, lst2 with
        | Cons(hd1, tl1), Cons(hd2, tl2) ->
            if hd1 > hd2
            then 1
            elif hd1 < hd2
            then 2
            else compare tl1 tl2
        | Cons(hd1, tl1), Empty -> 1
        | Empty, Cons(hd2, tl2) -> 2
        | Empty, Empty -> -1


let rec cutOff lst =
    match lst with
    | Cons(0, Empty) -> Cons (0, Empty)
    | Empty -> Empty
    | Cons(hd, tl) ->
        if hd = 0
        then cutOff tl
        else Cons (hd, tl) 


let rec leftToRight (lst: MyList<int>) =
    match lst with
    | Empty -> Empty
    | Cons (hd, tl) -> 
        let rec getLast lst =
            match lst with
            | Empty -> 0
            | Cons (hd, Empty) -> hd
            | Cons (hd, tl) -> getLast tl
        let rec noTail lst =
            match lst with 
            | Cons (hd, Empty) -> Empty
            | Cons (hd, tl) -> Cons (hd, noTail tl)
            | Empty -> Empty
        Cons(getLast lst, leftToRight (noTail lst))


let rec increment (sign1: int) (num1: MyList<int>) (sign2: int) (num2: MyList<int>) carry =
    match num1, num2 with
    | Empty, Empty ->
        if carry <> 0
        then Cons(carry, Empty)
        else Empty
    | Cons(hd1, tl1), Cons(hd2, tl2) ->
        let digit1 = sign1 * hd1 + sign2 * hd2 + carry
        if digit1 >= 10
        then 
            Cons(digit1 % 10, increment sign1 tl1 sign2 tl2 (digit1 / 10))
        else
            if digit1 >= 0
            then Cons(digit1, increment sign1 tl1 sign2 tl2 (digit1 / 10))
            else Cons(digit1 + 10, increment sign1 tl1 sign2 tl2 -1)

    | Cons(hd1, tl1), Empty | Empty, Cons(hd1, tl1) ->
        let digit2 = hd1 + carry
        if digit2 >= 10
        then Cons(digit2 % 10, increment sign1 tl1 sign2 Empty (digit2 / 10))
        elif digit2 < 0
        then Cons(digit2 + 10, increment sign1 tl1 sign2 Empty -1)
        else Cons(digit2, increment sign1 tl1 sign2 Empty (digit2 / 10))


let sum (num1: Num) (num2: Num) =
    let addition (num1: Num) (num2: Num) =
        match num1 with
        | sign1, num1 ->
            match num2 with
            | sign2, num2 ->
                let high = compare num1 num2
                if sign1 = sign2
                then sign1, cutOff(leftToRight(increment 1 (leftToRight num1) 1 (leftToRight num2) 0))
                else
                    if high = 1
                    then 
                        if sign1 = 1
                        then sign1, cutOff(leftToRight(increment sign1 (leftToRight num1) sign2 (leftToRight num2) 0))
                        else sign1, cutOff(leftToRight(increment sign2 (leftToRight num1) sign1 (leftToRight num2) 0))
                    elif high = 2
                    then
                        if sign2 = 1
                        then sign2, cutOff(leftToRight(increment sign1 (leftToRight num1) sign2 (leftToRight num2) 0))
                        else sign2, cutOff(leftToRight(increment sign2 (leftToRight num1) sign1 (leftToRight num2) 0))
                    else 
                        1, Cons(0, Empty)
    addition (num1: Num) (num2: Num)