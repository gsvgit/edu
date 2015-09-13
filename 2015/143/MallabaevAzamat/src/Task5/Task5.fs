module Task5

let main inArray lowBound highBound =
    Array.filter (fun x -> x < lowBound && x > highBound) inArray