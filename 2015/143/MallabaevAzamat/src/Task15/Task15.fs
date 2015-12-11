#light "off"
module Task15
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
| Smth (_6_4, _6_5) -> begin
_6_4
end))

let ___Smth____1 = (fun ( projectee  :  'a l__MyList ) -> (match (projectee) with
| Smth (_6_7, _6_6) -> begin
_6_6
end))




