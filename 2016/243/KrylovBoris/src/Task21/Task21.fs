module Task21
open Task15

let main inList: MyList<int> =
    
    let rec sort (lst: MyList<int>) =
      match lst with
          |Empty -> 
              lst
          |Cons(h, Empty) -> 
              lst
          |Cons(hd, tl) -> 
              if tl.head() <= hd 
              then
                  Cons(tl.head(), (sort (Cons (hd, tl.tail()))))
              else
                  Cons(hd, sort(tl))

    let rec cycle (list: MyList<int>) count =
        if count < list.length()
        then
            cycle (sort list) (count+1)
        else
            list
    cycle inList 0