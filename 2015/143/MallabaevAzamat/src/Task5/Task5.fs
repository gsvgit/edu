module Task5

let main inArray lowBound highBound =
    Array.map (fun (i, x) -> i) (Array.filter (fun (i, x) -> x < lowBound && x > highBound) (Array.mapi (fun i x -> (i, x)) inArray))