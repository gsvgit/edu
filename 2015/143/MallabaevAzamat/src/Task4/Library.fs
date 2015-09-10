namespace Task4

/// Documentation for my library
///
/// ## Example
///
///     let h = main 1
///     printfn "%d" h
///
module Library = 
  
  /// Returns x^4 + x^3 + x^2 + x
  ///
  /// ## Parameters
  ///  - `x` - whatever
  let main (inArray:array<int>) (num:int) = 
    let isNotBetter (t:int) = (t <= num)

    //let mutable ind_list = []
    //let mutable len = 0
    //for item_id in 0..inArray.Length - 1 do
    //    if isNotBetter inArray.[item_id] then
    //        ind_list <- item_id :: ind_list
    //        len <- len + 1
    //let outArray = [|for item in ind_list -> item|]

    Array.filter isNotBetter inArray
