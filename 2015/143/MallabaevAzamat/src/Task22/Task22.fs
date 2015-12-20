#light "off"
module Task22
type 'a l__MyList =
| Empty
| Smth of 'a * 'a l__MyList

let is_Empty = (fun ( _discr_ ) -> (match (_discr_) with
| Empty -> begin
true
end
| _ -> begin
false
end))

let is_Smth = (fun ( _discr_ ) -> (match (_discr_) with
| Smth (_) -> begin
true
end
| _ -> begin
false
end))

let ___Smth____0 = (fun ( projectee  :  'a l__MyList ) -> (match (projectee) with
| Smth (_2_4, _2_5) -> begin
_2_4
end))

let ___Smth____1 = (fun ( projectee  :  'a l__MyList ) -> (match (projectee) with
| Smth (_2_7, _2_6) -> begin
_2_6
end))

let rec length = (fun ( l  :  'a l__MyList ) -> (match (l) with
| Empty -> begin
0
end
| Smth (_2_14, t) -> begin
(1 + (length t))
end))

type 'a l__Pred =
'a  ->  Prims.bool

let un = (fun ( pred  :  'a l__Pred ) ( x  :  'a ) -> (false = (pred x)))

let app = (fun ( x  :  'a ) ( f  :  ('a * 'b) l__Pred ) ( y  :  'b ) -> (f (x, y)))

let first = (fun ( _2_30  :  ('a * 'b) ) -> (match (_2_30) with
| (a, _2_29) -> begin
a
end))

let second = (fun ( _2_36  :  ('a * 'b) ) -> (match (_2_36) with
| (_2_34, b) -> begin
b
end))

let where = (fun ( lst  :  'a l__MyList ) ( pred  :  'a l__Pred ) -> (match (lst) with
| Empty -> begin
Empty
end
| Smth (x, xs) -> begin
(match ((pred x)) with
| true -> begin
lst
end
| false -> begin
xs
end)
end))

let isEmpty = (fun ( lst  :  'a l__MyList ) -> (Empty = lst))

let rec merge = (fun ( _2_51  :  'a l__MyList ) ( tl  :  'a l__MyList ) -> (match (_2_51) with
| Smth (h, t) -> begin
(match ((isEmpty t)) with
| true -> begin
Smth (h, tl)
end
| false -> begin
Smth (h, (merge t tl))
end)
end))

let rec isSorted = (fun ( lst  :  'a l__MyList ) ( pred  :  ('a * 'a) l__Pred ) -> (match (lst) with
| Empty -> begin
true
end
| Smth (x, xs) -> begin
((isEmpty (where lst (app x pred))) && (isSorted xs pred))
end))

type 'a l__SortedList =
('a l__MyList * ('a * 'a) l__Pred)




