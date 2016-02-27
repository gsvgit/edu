#light "off"
module Task30
type l__Num =
| Pos of Prims.unit Task15.l__MyList
| Neg of Prims.unit Task15.l__MyList

let is_Pos = (fun ( _discr_ ) -> (match (_discr_) with
| Pos (_) -> begin
true
end
| _ -> begin
false
end))

let is_Neg = (fun ( _discr_ ) -> (match (_discr_) with
| Neg (_) -> begin
true
end
| _ -> begin
false
end))

let ___Pos____0 : l__Num  ->  Prims.unit Task15.l__MyList = (fun ( projectee  :  l__Num ) -> (match (projectee) with
| Pos (_2_3) -> begin
_2_3
end))

let ___Neg____0 : l__Num  ->  Prims.unit Task15.l__MyList = (fun ( projectee  :  l__Num ) -> (match (projectee) with
| Neg (_2_6) -> begin
_2_6
end))

let inc : l__Num  ->  l__Num = (fun ( f  :  l__Num ) -> (match (f) with
| Neg (Task15.Empty) -> begin
Pos (Task15.Smth ((), Task15.Empty))
end
| Neg (Task15.Smth ((), n)) -> begin
Neg (n)
end
| Pos (n) -> begin
Pos (Task15.Smth ((), n))
end))

let dec : l__Num  ->  l__Num = (fun ( f  :  l__Num ) -> (match (f) with
| Pos (Task15.Empty) -> begin
Neg (Task15.Smth ((), Task15.Empty))
end
| Pos (Task15.Smth ((), n)) -> begin
Pos (n)
end
| Neg (n) -> begin
Neg (Task15.Smth ((), n))
end))

let sum : l__Num  ->  l__Num  ->  l__Num = (fun ( f  :  l__Num ) ( s  :  l__Num ) -> (match (f) with
| Pos (n) -> begin
(Task15.foldU n s inc)
end
| Neg (n) -> begin
(Task15.foldU n s dec)
end))

let add : l__Num  ->  l__Num  ->  l__Num = (fun ( f  :  l__Num ) ( s  :  l__Num ) -> (sum f s))

let un : l__Num  ->  l__Num = (fun ( n  :  l__Num ) -> (match (n) with
| Pos (x) -> begin
Neg (x)
end
| Neg (x) -> begin
Pos (x)
end))

let mul : l__Num  ->  l__Num  ->  l__Num = (fun ( f  :  l__Num ) ( s  :  l__Num ) -> (match (f) with
| Pos (n) -> begin
(Task15.foldU n (Pos (Task15.Empty)) (add s))
end
| Neg (n) -> begin
(un (Task15.foldU n (Pos (Task15.Empty)) (add s)))
end))




