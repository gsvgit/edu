namespace Task3

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
  let main x = 
    let square_x = x * x
    (square_x + x) * (square_x + 1)

