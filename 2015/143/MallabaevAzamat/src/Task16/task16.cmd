copy ..\common\prims.fs
copy ..\Task15\task15.fst
fstar --codegen FSharp task15.fst task16.fst
fsc --nowarn:62 --nowarn:25 --target:library prims.fs task15.fs task16.fs
