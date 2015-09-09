namespace Task2

/// Documentation for my library
///
/// ## Example
///
///     let h = main 1
///     printfn "%d" h
///
module Library = 
  
  /// Returns a^n
  /// 
  /// ## Parameters
  /// - `a` - base
  /// - `n` - exponent
  let rec (^) (a:int) (n:int) = if n < 0 then 1 else if n = 0 then 1 else a * (a ^ (n - 1))

  /// Returns x^4 + x^3 + x^2 + x
  ///
  /// ## Parameters
  ///  - `x` - whatever
  let main x = (x ^ 4) + (x ^ 3) + (x ^ 2) + x

