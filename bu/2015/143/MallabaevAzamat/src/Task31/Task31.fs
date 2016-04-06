#light "off"
module Task31
let add : Task30.l__Num  ->  Task30.l__Num  ->  Task30.l__Num = (fun ( f  :  Task30.l__Num ) ( s  :  Task30.l__Num ) -> (Task30.sum f s))

let un : Task30.l__Num  ->  Task30.l__Num = (fun ( n  :  Task30.l__Num ) -> (match (n) with
| Task30.Pos (x) -> begin
Task30.Neg (x)
end
| Task30.Neg (x) -> begin
Task30.Pos (x)
end))

let mul : Task30.l__Num  ->  Task30.l__Num  ->  Task30.l__Num = (fun ( f  :  Task30.l__Num ) ( s  :  Task30.l__Num ) -> (match (f) with
| Task30.Pos (n) -> begin
(Task15.foldU n (Task30.Pos (Task15.Empty)) (add s))
end
| Task30.Neg (n) -> begin
(un (Task15.foldU n (Task30.Pos (Task15.Empty)) (add s)))
end))




