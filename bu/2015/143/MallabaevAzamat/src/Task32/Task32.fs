#light "off"
module Task32
let isPos : Task30.l__Num  ->  Prims.bool = (fun ( n  :  Task30.l__Num ) -> (match (n) with
| (Task30.Neg (Task15.Empty)) | (Task30.Pos (_)) -> begin
true
end
| _4_8 -> begin
false
end))

let rec toNat : Prims.int  ->  Task30.l__Num = (fun ( n  :  Prims.int ) -> (match (n) with
| 0 -> begin
Task30.Pos (Task15.Empty)
end
| _4_15 -> begin
(Task30.inc (toNat (n - 1)))
end))

let rec toNum : Prims.int  ->  Task30.l__Num = (fun ( n  :  Prims.int ) -> (match (n) with
| 0 -> begin
Task30.Pos (Task15.Empty)
end
| _4_19 -> begin
(match ((n > 0)) with
| true -> begin
(Task30.inc (toNat (n - 1)))
end
| false -> begin
(Task31.un (Task30.inc (toNat ((- (n)) - 1))))
end)
end))

let unBool : Prims.bool  ->  Prims.bool = (fun ( n  :  Prims.bool ) -> (match (n) with
| true -> begin
false
end
| false -> begin
true
end))

let isDivBy2 : Task30.l__Num  ->  Prims.bool = (fun ( n  :  Task30.l__Num ) -> (match (n) with
| Task30.Pos (xs) -> begin
(Task15.foldU xs true unBool)
end
| Task30.Neg (xs) -> begin
(Task15.foldU xs true unBool)
end))




