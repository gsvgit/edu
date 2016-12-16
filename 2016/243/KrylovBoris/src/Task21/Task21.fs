module Task21
open Task15

let main inList: MyList<int> =
    
    let rec sort (lst: MyList<int>) =
      match lst with
          |Empty -> lst
          |Cons(hd, tl) -> 
              if tl <> Empty
              then
                  if head tl <= hd 
                  then
                      Cons(head tl, (sort (Cons (hd, tail tl))))
                  else
                      Cons(hd, sort(tl))
              else
                  lst

    let rec cycle (list: MyList<int>) count =
        if count < length list
        then
            cycle (sort list) (count+1)
        else
            list
    cycle inList 0