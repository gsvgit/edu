#light "off"
module Task22
let rec where = (fun ( lst  :  'a Task15.l__MyList ) ( pred  :  'a  ->  Prims.bool ) -> (match (lst) with
| Task15.Empty -> begin
Task15.Empty
end
| Task15.Smth (x, xs) -> begin
(match ((pred x)) with
| true -> begin
Task15.Smth (x, (where xs pred))
end
| false -> begin
(where xs pred)
end)
end))

let rec merge = (fun ( fl  :  'a Task15.l__MyList ) ( sl  :  'a Task15.l__MyList ) -> (match (fl) with
| Task15.Empty -> begin
sl
end
| Task15.Smth (x, xs) -> begin
Task15.Smth (x, (merge xs sl))
end))

let quickSort : Prims.int Task15.l__MyList  ->  Prims.int Task15.l__MyList = (fun ( lst  :  Prims.int Task15.l__MyList ) -> (match (lst) with
| Task15.Empty -> begin
Task15.Empty
end
| Task15.Smth (x, xs) -> begin
(merge (where xs (fun ( it  :  Prims.int ) -> (it < x))) (Task15.Smth (x, (where xs (fun ( it  :  Prims.int ) -> (it > x))))))
end))




